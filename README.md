# Football Team and Player Management System

A robust Windows Forms desktop application built with C# for managing football organizations. This system allows users to maintain detailed records of teams and their rosters, providing powerful tools for sorting and filtering data.

## Features

### Team Management
- **View Teams**: Browse all existing teams in a comprehensive data grid.
- **Add/Edit/Delete**: Easily manage the lifecycle of a team, including details like Team Name, Coach, and Year established.
- **Flexible Sorting**: Organize team data by ID, Team Name, Coach name, or Year.

### Player Management
- **Roster Control**: Add, edit, or remove players from the system.
- **Detailed Profiles**: Track player names, jersey numbers, positions, and team affiliations.
- **Advanced Sorting**: Sort the player list by ID, Name, Number, Position, or Team ID.
- **Data Filtering**: Specifically filter the player list by Team ID to view individual team rosters.

## Technical Overview

- **Language**: C#
- **Framework**: .NET Windows Forms (WinForms)
- **Data Storage**: Local database integration using ADO.NET DataSets (`Database1DataSet`).
- **Architecture**: Event-driven UI with dedicated forms for specialized tasks (Sorting, Adding, Editing).

## Project Structure

- `App/Forms/`: Contains the UI logic for all screens (Main, Help, Add/Edit Team, Add/Edit Player, View/Sort).
- `App/Program.cs`: The entry point for the application.
- `App/Database1DataSet`: Managed data structures for team and player information.

## How to Use

1. **Launch**: Start the application via `mainForm`.
2. **Navigate**: Use the dashboard buttons to access different modules:
   - **Add / Edit Team**: Manage the list of clubs.
   - **Add / Edit Player**: Manage the roster of athletes.
   - **View/Sort**: Use the specialized view and sort buttons to organize your data.
   - **Filter Players**: Use this to drill down into specific team rosters.
3. **Help**: If you get stuck, click the **Help?** button on the Main Form for a detailed user guide.

## Copyright
Copyright © 2026
