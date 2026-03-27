[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/hZIAsDPT)
# CSCI 1260 — Project

## Project Instructions
All project requirements, grading criteria, and submission details are provided on **D2L**.  
Refer to D2L as the *authoritative source* for this assignment.

This repository is intentionally minimal. You are responsible for:
- Creating the solution and projects
- Designing the class structure
- Implementing the required functionality

---

## Getting Started (CLI)

You may use **Visual Studio**, **VS Code**, or the **terminal**.

### Create a solution
```bash
dotnet new sln -n ProjectName
```

### Create a project (example: console app)
```bash
dotnet new console -n ProjectName.App
```

### Add the project to the solution
```bash
dotnet sln add ProjectName.App
```

### Build and run
```bash
dotnet build
dotnet run --project ProjectName.App
```

## Notes
- Commit early and commit often.
- Your repository history is part of your submission.
- Update this README with build/run instructions specific to your project.

## UML Diagram
- https://etsu365-my.sharepoint.com/:i:/g/personal/gutierrezver_etsu_edu/IQBtF4SfdykqTbcx9nQU43vMAYxz1bPEioO1JssmCUYZZQg?e=9UPo7s

## Build and run Project
- To build and run this project, you will need to us this code:
- dotnet build
- dotnet run --project WarGame/WarGame.Console

## Project
- This project is a card game called War.
- You can play against multiple players by typing how many players you want to play. 
- This ranging from 2-4 players.
- - The game will continue until there is a winner or if you reach the maximun number of rounds which is 10,000.