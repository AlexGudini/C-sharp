#include "stdafx.h"
#define _SCL_SECURE_NO_WARNINGS
#include <stdio.h>
#include <iostream>
#include <fstream>
#include <mutex>
#include <string>
#include <Windows.h>

#pragma warning(disable : 4996)

using namespace std;

BOOL nextString;

FILE *freading;
FILE *fwriting;

char ch[100];
char fnamew[100];
char readString[100] = "d:\\out.txt";

#define SHARED_MEMORY_DATE "OSFileMapData"
#define SHARED_MEMORY_STATUS "OSFileMapStatus"
#define SHARED_MEMORY_SIZE 256

string currentLine;

HANDLE hMutex = INVALID_HANDLE_VALUE;

HANDLE hFile;
HANDLE hMapFile;
HANDLE hStatus;

LPCTSTR lSharedData;
char* lSharedStatus;

void ReadFile() {

	while (true) {
		WaitForSingleObject(hMutex, INFINITE);
		

		cout << "write the path for reading: " << endl;
		cin >> fnamew;

		//
		freading = fopen(fnamew, "rb");
		//пока не закончится файл
		while (!feof(freading))
		{
			//
			WaitForSingleObject(hMutex, INFINITE);
			fgets(ch, 100, freading);

			cout << ch << " + " << sizeof(ch) << endl;

			///////
			memset(lSharedStatus, strlen(ch), 16);
			//
			CopyMemory((PVOID)lSharedData, ch, strlen(ch));

			

			ReleaseMutex(hMutex);
			cout << hMutex<< endl;
			Sleep(5000);
			//break;
		}
		fclose(freading);
		break;
	}
}

void WriteFile() {

	while (true)
	{
		WaitForSingleObject(hMutex, INFINITE);

		cout << "Write work";
		

		fwriting = fopen(readString, "ab+");

		int status = int(lSharedStatus[0]);
		if (!status)
		{
			break;
		}

		string currentLine(lSharedData, status);
		cout << currentLine << endl;
		fwrite(lSharedData, 1, sizeof(ch), fwriting);
		
		fclose(fwriting);
		ReleaseMutex(hMutex);
		//break;
	}
	
}

bool CreateNewProcess(char path[MAX_PATH], PROCESS_INFORMATION& processInfo)
{
	STARTUPINFO startupInfo;
	ZeroMemory(&startupInfo, sizeof(startupInfo));
	startupInfo.cb = sizeof(startupInfo);
	ZeroMemory(&processInfo, sizeof(processInfo));
	if (!CreateProcess(NULL, path, NULL, NULL, FALSE, CREATE_NEW_CONSOLE, NULL, NULL, &startupInfo, &processInfo))
		return false;

	wcout << "process \"" << path << "\" success created!\n";
	wcout << "description process: " << processInfo.hProcess << endl;
	wcout << "ID process: " << processInfo.dwProcessId << endl;
	return true;
}

void CloseProcess(PROCESS_INFORMATION& processInfo)
{
	CloseHandle(processInfo.hProcess);
	CloseHandle(processInfo.hThread);
}

int main(int argc, char* argv[])
{
	hMutex = ::CreateMutex(NULL, FALSE, "OSMu");
	if (hMutex == NULL)
	{
		cout << "Error: " << GetLastError() << endl;
		cout << "Create mutex failed." << endl;
		cout << "Press any key to exit." << endl;
		system("pause");
		return GetLastError();
	}

	hFile = CreateFile("B:\\MapFile.dat", GENERIC_READ | GENERIC_WRITE,
		FILE_SHARE_READ | FILE_SHARE_WRITE, NULL, CREATE_ALWAYS,
		FILE_ATTRIBUTE_NORMAL, NULL);

	hMapFile = CreateFileMapping(hFile, NULL, PAGE_READWRITE, 0, SHARED_MEMORY_SIZE, "OSFileMapData");
	lSharedData = (LPTSTR)MapViewOfFile(hMapFile, FILE_MAP_ALL_ACCESS, 0, 0, SHARED_MEMORY_SIZE);

	hStatus = CreateFile("B:\\status.dat", GENERIC_READ | GENERIC_WRITE,
		FILE_SHARE_READ | FILE_SHARE_WRITE, NULL, CREATE_ALWAYS,
		FILE_ATTRIBUTE_NORMAL, NULL);

	HANDLE hMapStatus = CreateFileMapping(hStatus, NULL, PAGE_READWRITE, 0, SHARED_MEMORY_SIZE, "OSFileMapStatus");
	lSharedStatus = (char*)::MapViewOfFile(hMapStatus, FILE_MAP_ALL_ACCESS, 0, 0, SHARED_MEMORY_SIZE);

	char curentPath[MAX_PATH];

	if (argc == 1)
	{
		PROCESS_INFORMATION processInfoRead;
		PROCESS_INFORMATION processInfoWrite;

		/// Блокируем поток для синхронизации процесов
		WaitForSingleObject(hMutex, INFINITE);
		cout << "Default path: " << endl;

		/// Получаем имя исполняемого файла
		GetModuleFileName(NULL, curentPath, MAX_PATH);
		CreateNewProcess(strcat(curentPath, " R"), processInfoRead);
		GetModuleFileName(NULL, curentPath, MAX_PATH);
		CreateNewProcess(strcat(curentPath, " W"), processInfoWrite);

		Sleep(1000);
		/// Разблокируем поток 
		ReleaseMutex(hMutex);
		
		/// ждем пока дочерние процессs закончит работу
		WaitForSingleObject(processInfoRead.hProcess, INFINITE);
		WaitForSingleObject(processInfoWrite.hProcess, INFINITE);
		CloseProcess(processInfoRead);
		CloseProcess(processInfoWrite);
	}
	else
	{
		switch (*argv[1])
		{
		case 'R':
			cout << "Read path: " << endl;
			ReadFile();
			break;
		case 'W':
			cout << "Write path: " << endl;
			WriteFile();
			break;
		default:
			cout << "Error path: " << *argv[1] << endl;
			break;
		}
	}

	/// Очистка памяти
	UnmapViewOfFile(lSharedData);
	CloseHandle(hMapFile);

	UnmapViewOfFile(lSharedStatus);
	CloseHandle(hMapStatus);
	CloseHandle(hMutex);
	system("pause");

	return 0;
}