# Hirarchical-Menu-System

## Overview
This project implements a hierarchical menu system in C# using Object-Oriented Programming (OOP) principles, including interfaces, delegates, and polymorphism. The system allows users to navigate menus, execute actions, and manage a structured menu hierarchy.

## Features
- **Hierarchical Menu System**: Supports nested menus and actions.
- **Polymorphism & Interfaces**: Implements an interface-based approach for menu item actions.
- **Delegates & Events**: Uses `Action<T>` delegates for handling user-selected actions dynamically.
- **Console UI**: Provides a command-line-based menu navigation system.

## Implementation Details
The project consists of three main components:
1. **Menus.Interfaces**: Implements the menu system using interfaces.
2. **Menus.Events**: Implements the menu system using delegates and events.
3. **Menus.Test**: A test application that demonstrates the usage of both implementations.

## How It Works
1. The main menu (`MainMenu`) is displayed with selectable options.
2. Users can navigate through submenus and execute actions.
3. Selecting an action triggers the corresponding function.
4. The menu system ensures valid input handling and supports back navigation.

### Example Menu Flow
```
** Main Menu **
----------------
1. Letters and Version
2. Show Current Date/Time
0. Exit

Please enter your choice (1-2 or 0 to exit):
>> 1

** Letters and Version **
--------------------------
1. Show Version
2. Count Lowercase Letters
0. Back
```

## Setup & Running the Project
1. Clone the repository.
2. Open the solution in **Visual Studio**.
3. Build and run `Ex04.Menus.Test` to test the system.

## Notes
- The menu system follows best coding practices (modular design, code reuse, and separation of concerns).
- Proper error handling ensures robustness.
- The `Coding Standards` document should be followed for consistency.

## License
This project is for educational purposes and follows the guidelines set by the course materials.



