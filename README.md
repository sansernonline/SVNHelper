# SVNHelper

> A Windows tool for batch-checking-out multiple SVN projects at once, using SharpSvn — part of an internal release-engineering toolkit.

![.NET](https://img.shields.io/badge/.NET%20Framework-4.5.2-512BD4)
![Language](https://img.shields.io/badge/Lang-C%23-239120?logo=csharp)
![UI](https://img.shields.io/badge/UI-WinForms-blue)
![SVN](https://img.shields.io/badge/SVN-SharpSvn-809CC9)

---

## Overview

**SVNHelper** lets you select several projects from a list and check them all out from Subversion into a chosen folder in one operation. Instead of running `svn checkout` repeatedly for each project, you pick the projects, enter your SVN credentials and a destination path, and the tool checks each one out in the background with progress feedback.

## Features

- **Project picker** — a dual-list (left/right) UI to select which projects to check out, with move-one and move-all controls
- **Batch checkout** — checks out each selected project's `trunk` via SharpSvn (`SvnClient.CheckOut`)
- **Runtime credentials** — SVN username/password are entered in the form at run time (not stored in the project)
- **Responsive UI** — checkout runs on a `BackgroundWorker` with progress reporting and a cancel button
- **Input validation** — requires destination folder, username, and password before running

## Architecture

- **`Program.cs`** — entry point, launches `MainForm`
- **`MainForm.cs`** — UI: project lists, browse/credentials fields, checkout via background worker
- **`classes/Helper.cs`** — wraps SharpSvn (`doCheckOut`), credential setup, and list-box helpers; pulls the project list from `SVNProjectList`
- **`libs/`** — `SVNProjectList.dll` (project list) and the **SharpSvn** native/managed libraries

## Project structure

```
SVNHelper/
├── SVNHelper.sln
└── SVNHelper/
    ├── Program.cs
    ├── MainForm.cs / MainForm.Designer.cs
    ├── classes/Helper.cs          # SharpSvn wrapper + list helpers
    ├── libs/
    │   ├── SVNProjectList.dll      # supplies the project list
    │   └── SharpSvn/               # SharpSvn libraries
    ├── assets/                     # icons, sample project list (xlsx)
    └── App.config
```

## Build & Run

1. Open `SVNHelper.sln` in **Visual Studio** (targets .NET Framework 4.5.2)
2. Ensure the references to `SVNProjectList.dll` and the SharpSvn libraries in `libs/` resolve
3. Build and run, then:
   - move the projects you want into the selected list
   - enter your SVN username, password, and a destination folder
   - click **Checkout**

## Configuration

The SVN base URL is defined in `classes/Helper.cs`:

```csharp
private const string SVNURL = "https://<your-svn-host>/svn/{0}/trunk/{1}";
```

Replace it with your own repository URL pattern. The list of projects comes from `SVNProjectList.dll` — update that to match your environment.

> **Note:** the bundled URL points to an internal Subversion server. If you publish this repo, replace the internal hostname with a placeholder so you don't expose internal infrastructure. (No passwords are stored in the code — credentials are supplied at runtime.)

## Notes

One of a set of internal release-engineering tools that share the same `SVNProjectList` library and project conventions. A clean example of wrapping SharpSvn for batch operations with a responsive WinForms UI.
