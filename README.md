# Library Management System (Console App)

<div align="center">

![GitHub issues](https://img.shields.io/github/issues/Hamza-92/Library-Management-System-Console-App)
![GitHub forks](https://img.shields.io/github/forks/Hamza-92/Library-Management-System-Console-App)
![GitHub stars](https://img.shields.io/github/stars/Hamza-92/Library-Management-System-Console-App)
![GitHub license](https://img.shields.io/github/license/Hamza-92/Library-Management-System-Console-App)
![GitHub last commit](https://img.shields.io/github/last-commit/Hamza-92/Library-Management-System-Console-App)

</div>

---

## Table of Contents

1. [Overview](#overview)  
2. [Features](#features)  
3. [Technologies Used](#technologies-used)  
4. [Project Structure](#project-structure)  
5. [Installation & Usage](#installation--usage)  
   - [Prerequisites](#prerequisites)  
   - [Steps to Run](#steps-to-run)  
6. [How to Use](#how-to-use)  
7. [Contributing](#contributing)  
8. [Security Policy](#security-policy)  
9. [License](#license)  
10. [Contact](#contact)  

---

## Overview  

The **Library Management System** is a simple yet effective console-based application developed in **C#**. This project provides users with the ability to manage a library of books, including adding, viewing, borrowing, returning, and removing books. The system implements **persistent storage** using JSON, ensuring that data is saved even after the application is closed.  

This project is designed for learning purposes and can be extended with more advanced functionalities.  

---

## Features  

- **Persistent Storage**: Book data is saved and loaded from a JSON file.  
- **Add Book**: Store new books with a title, author, and publication year.  
- **View Books**: Display all books with their availability status.  
- **Borrow Book**: Mark a book as borrowed.  
- **Return Book**: Mark a book as returned.  
- **Remove Book**: Delete a book from the library with a confirmation prompt.  
- **User-Friendly Console UI**: A well-structured and formatted interface for ease of use.  

---

## Technologies Used  

- **Programming Language**: C#  
- **Development Environment**: .NET Console Application  
- **Data Storage**: JSON (using `Newtonsoft.Json`)  

---

## Project Structure
```
Library Management System
├── Library Management System.sln  # Solution file
├── Library Management System      # Main project folder
│   ├── src                        # Source folder
│   │   ├── Program.cs             # Main application file
│   │   ├── Book.cs                # Book class file
│   │   ├── Library.cs             # Library class file
│   │   ├── StorageManager.cs      # Storage canager class file
│   │   ├── UserInputHelper.cs     # User input helper class file
├── .github                        # GitHub-related files
│   ├── ISSUE_TEMPLATE             # Issue template
│   ├── CODE_OF_CONDUCT.md         # Code of Conduct
│   ├── CONTRIBUTING.md            # Contribution guidelines
├── .gitattributes                 # Git attributes file
├── .gitignore                     # Git ignore file
├── LICENSE                        # MIT License
├── README.md                      # Project documentation
├── SECURITY.md                    # Security policies
```

---

## Installation & Usage

### Prerequisites
- Install **.NET SDK** from [Microsoft .NET](https://dotnet.microsoft.com/en-us/download)

### Steps to Run
1. **Clone the Repository**
   ```sh
   git clone https://github.com/Hamza-92/Library-Management-System-Console-App.git
   ```
2. **Navigate to the project directory**
   ```sh
   cd "Library Management System"
   ```
3. **Restore Dependencies**
   ```sh
   dotnet restore
   ```
4. **Run the Application**
   ```sh
   dotnet run
   ```

---

## How to Use
### Main Menu
After running the application, you will see the following menu:
```
=========================
Library Management System
=========================
1. Add a Book
2. View Books
3. Borrow a Book
4. Return a Book
5. Remove a Book
6. Exit
Enter your choice:
```
### Operations
#### Add a Book
- Select option 1 and enter the title, author, and publication year.
- The book will be added and stored in the library.
#### View Books
- Select option 2 to list all books along with their status (Available/Borrowed).
#### Borrow a Book
- Select option 3 and choose a book from the displayed list.
- If available, it will be marked as Borrowed.
#### Return a Book
- Select option 4 and choose a book to return.
- The book status will change back to Available.
#### Remove a Book
- Select option 5, and the book list will be displayed.
- Choose the book you want to delete.
- A confirmation prompt will appear before deletion.
#### Exit
- Select option 6 to close the application.

---

## Contributing
We welcome contributions! Please read our [CONTRIBUTING.md](.github/CONTRIBUTING.md) to get started.

---

## Security Policy
For reporting vulnerabilities, please refer to our [SECURITY.md](SECURITY.md).

---

## License
This project is licensed under the **MIT License** – see the [LICENSE](LICENSE) file for details.

---

## Contact
- **GitHub**: [Hamza-92](https://github.com/Hamza-92)
- **Email**: ameerhamza92099@gmail.com
