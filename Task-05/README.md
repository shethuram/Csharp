# 📌 CS-05: File I/O and Exception Handling

## 🎯 Objective

Develop a console-based application that reads data from a file, processes it, and writes the result to another file while handling potential runtime errors safely.

---

## 📋 Requirements

* Read text from a file
* Process the data (count lines and words)
* Write the result to a new file
* Implement exception handling for file-related errors

---

## 🛠️ Implementation

### 🔹 File Reading

* Used `File.ReadAllText()` to read entire file content
* Used `File.ReadAllLines()` to count number of lines

---

### 🔹 Data Processing

* Counted total lines using array length
* Counted words using `Split()` with multiple separators:

  * space `' '`
  * newline `\\n`
  * carriage return `\\r`
  * tab `\\t`
* Used `StringSplitOptions.RemoveEmptyEntries` to avoid empty values

---

### 🔹 File Writing

* Used `File.WriteAllText()` to write processed results to output file
* Ensures file is created or overwritten safely

---

### 🔹 Exception Handling

* Wrapped file operations inside `try-catch`
* Handled specific exceptions:

  * `FileNotFoundException`
  * `UnauthorizedAccessException`
  * `IOException`
* Added generic exception handling for unexpected errors

---

### 🔹 Validation

* Used `File.Exists()` to check file presence before reading
* Prevented runtime crashes due to missing files

---

## ⚙️ Features

* Reads and processes external file data
* Accurate word counting with proper handling of `\\r\\n`
* Handles empty lines and extra spaces
* Robust error handling for file operations
* Clean and structured output generation

---

## 📸 Output

## input.txt
```text
Hello world
This is a sample file

It contains multiple lines,
and    multiple   spaces.

C# File I/O is important.
```
---

# output.txt
```text
File Analysis Result
---------------------
Total Lines: 7
Total Words: 19
```
---

## 📚 Learnings

* Working with file operations using `System.IO`
* Understanding difference between `ReadAllText` and `ReadAllLines`
* Handling real-world text processing issues (`\\r\\n`)
* Importance of exception handling in file operations
* Writing safe and defensive code

---

