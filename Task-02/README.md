# 👤 CS-02: Person Class with Properties and Methods

## 🎯 Objective

Create a `Person` class with properties and a method to demonstrate basic object-oriented programming concepts in C#.

---

## 📋 Requirements

* Define properties: `Name`, `Age`
* Implement method: `Introduce()`
* Create multiple `Person` objects and call `Introduce()`

---

## ⚙️ What I Implemented

* Created a `Person` class with:

  * Private fields (`_name`, `_age`)
  * Public properties using `get` and `set`
* Implemented validation inside `set`:

  * Prevent negative age values
* Added `Introduce()` method to print personalized message
* Instantiated multiple objects in `Main()` and invoked methods

---

## 🧠 Key Concepts Used

* Classes and Objects
* Encapsulation (private fields + public properties)
* Properties (`get`, `set`)
* Input validation
* Methods inside class

---

## ⚠️ Important Observations

* Default values in C#:

  * `int` → `0`
  * `string` → `null`
* If validation fails, value is not updated → default remains
* Non-nullable fields must be initialized (handled via best practices)

---

## 🧪 Sample Output
![](screenshots/o1.png)
---

## 💡 Learnings

* Understood how properties provide controlled access to data
* Learned importance of validation in `set`
* Gained clarity on default values and null handling in C#
* Practiced creating and using objects in a structured way

---
