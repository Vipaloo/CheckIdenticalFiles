# Duplicate Finder

## Overview

Duplicate Finder is a Windows Forms application designed to find and manage duplicate files within selected directories. The application allows users to select two directories, compare files within them, and move duplicate files to a specified directory.

## Features

- Select one or two directories to compare files.
- Specify a directory where to move duplicate files.
- Debug mode to preview actions without making changes.
- Process only or ignore specified file extensions.
- Canceling ongoing operations.

## Requirements

- .NET Framework 4.7.2 or later
- Visual Studio 2019 or later

## Installation

0. You can get already built version of programm just by downloading and running file ```DuplicateFinderV1.2.0.exe```

## or you can:

1. Clone the repository:
```bash
git clone https://github.com/vipaloo/WindowsFormsApp1.git
```
2. Open the solution file in Visual Studio.
3. Build the solution to restore the necessary packages.

## Usage

1. **Select Directories:**
    - Click the "Select 1st Folder" button to choose the first directory.
    - Click the "Select 2nd Folder" button to choose the second directory.

2. **Specify Duplicate Directory:**
    - Click the "Select Duplicate Folder" button to choose the directory where duplicate files will be moved.

3. **Process Files:**
    - Click the "Move Files" button to start processing and finding duplicates.
    - Use the "Stop Processing" button to cancel the operation if needed.

4. **Debug Mode:**
    - Enable the "Debug Mode" checkbox to preview actions without making changes.
