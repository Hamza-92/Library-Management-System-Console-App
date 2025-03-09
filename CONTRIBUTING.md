# Contributing to Library Management System (Console App)

We appreciate your interest in contributing to this project! To ensure a smooth collaboration, please follow these guidelines before making contributions.

## 🛠 How to Contribute

### 1️⃣ Fork the Repository
To contribute, you first need to create a personal copy of the repository.

1. Go to the repository: [Library Management System (Console App)](https://github.com/Hamza-92/Library-Management-System-Console-App).
2. Click the **Fork** button at the top-right to create a copy under your GitHub account.
3. Clone the forked repository to your local machine.

```sh
# Replace YOUR-USERNAME with your GitHub username
git clone https://github.com/YOUR-USERNAME/Library-Management-System-Console-App.git
cd Library-Management-System-Console-App
```

---

### 2️⃣ Set Up the Project Locally
Ensure that you have the required development environment:

- **Visual Studio** (or any preferred C# IDE)
- **.NET SDK** (if applicable)

After cloning, open the project in your IDE and ensure it runs without errors before making any changes.

---

### 3️⃣ Create a New Branch
To keep the `main` branch stable, all changes should be made in a separate branch.

```sh
git checkout -b feature-branch-name
```

🔹 Use a meaningful branch name:
- `feature-add-book-functionality`
- `bugfix-issue-23`
- `docs-update-readme`

---

### 4️⃣ Make Your Changes
- Follow the existing project structure.
- Keep code **clean, modular, and well-documented**.
- Ensure **no errors or warnings** before committing.
- If making UI changes (for console-based output), ensure **consistent formatting**.

---

### 5️⃣ Test Your Changes
Before committing, ensure:
- The application runs **without errors**.
- New functionality works as expected.
- No existing functionality is broken.

---

### 6️⃣ Commit and Push Changes
After testing, commit your changes with a **clear and descriptive commit message**:

```sh
git add .
git commit -m "Added book borrowing functionality"
git push origin feature-branch-name
```

Commit message format:
```
<type>: <short description>

<optional detailed description>
```
Examples:
- `feat: Added functionality to borrow books`
- `fix: Resolved issue with book return logic`
- `docs: Updated README with new setup instructions`

---

### 7️⃣ Open a Pull Request (PR)
Once your changes are pushed to your fork:

1. Navigate to the **original repository** on GitHub.
2. Click on **Pull Requests** → **New Pull Request**.
3. Select **your feature branch** and compare it with `main`.
4. Provide a **clear description** of your changes and reference any related issues.
5. Click **Create Pull Request**.

---

## 📌 Issue Guidelines
If you want to report a bug or request a feature, follow these steps:

### 🔍 Before Submitting an Issue:
- **Check existing issues** to avoid duplicates.
- Ensure your issue is **clearly described**.

### 📝 Creating an Issue:
- Use a **clear title** that describes the problem.
- Provide **detailed steps** to reproduce the issue.
- Attach **screenshots or logs** (if applicable).
- Suggest a **possible solution** if you have one.

### 🏷 Issue Labels:
- **`good first issue`**: Ideal for beginners.
- **`help wanted`**: Needs assistance from contributors.
- **`bug`**: A confirmed defect.
- **`enhancement`**: A feature request or improvement.
- **`documentation`**: Updates related to project docs.

---

## 🏗 Code Style Guidelines
- Use **meaningful variable and function names**.
- Maintain **proper indentation and spacing**.
- Keep **methods short and focused** (avoid large functions).
- Follow **C# best practices** for maintainability.

---

## 🤝 Need Help?
If you need assistance:
- Check the **Discussions** tab on GitHub.
- Open an **Issue** with your question.
- Contact the maintainer at **ameerhamza92099@gmail.com**.

Thank you for contributing! 🚀

