# 🧠 C# LINQ – Advanced Operators Training  
This project includes all LINQ exercises covering three major categories:

- **Restriction Operators**  
- **Ordering Operators**  
- **Transformation Operators**

All problems are implemented inside `Program.cs` and organized using `#region` blocks for easy testing and navigation.

---

## 📚 Project Structure
- **Program.cs** → Contains all LINQ questions (Q1 → Q20).  
- **ListGenerators.cs** → Provides ProductList & CustomerList.  
- **Customers.xml** → Source file for customer orders.

---

# 🧩 LINQ Topics & Questions

---

# 🔹 Restriction Operators (Filtering)
### **Q1 – Find all products that are out of stock**
Uses `Where()` to filter items by units in stock.

### **Q2 – Find products in stock with price > 3.00**
Demonstrates multiple conditions inside `Where()`.

### **Q3 – Return digits whose name length is shorter than their index**
Uses `Where()` with element + index overload.

---

# 🔹 Ordering Operators (Sorting)
### **Q1 – Sort products by name**  
Uses `OrderBy()`.

### **Q2 – Case-insensitive word sorting**  
Uses a custom comparer: `StringComparer.OrdinalIgnoreCase`.

### **Q3 – Sort products by units in stock (descending)**  
Uses `OrderByDescending()`.

### **Q4 – Sort digits by name length then alphabetically**  
`OrderBy().ThenBy()`.

### **Q5 – Sort words by length then alphabetically (case-insensitive)**  
Mix of sorting and custom comparers.

### **Q6 – Sort products by category then price (descending)**

### **Q7 – Sort words by length then case-insensitive descending order**

### **Q8 – Reverse digits whose second letter = 'i'**  
Filtering + `.Reverse()`.

---

# 🔹 Transformation Operators (Select / Projection)
### **Q1 – Select only product names**
`Select(p => p.ProductName)`.

### **Q2 – Create uppercase + lowercase versions of words (Anonymous Types)**

### **Q3 – Project product properties and rename UnitPrice → Price**

### **Q4 – Check if array element equals its index**  
Uses `Select()` with index.

### **Q5 – Return all pairs where numberA < numberB**
Nested LINQ query using `from…from`.

### **Q6 – Select orders where total < 500**

### **Q7 – Select orders from year 1998 or later**

---

# 🎯 Learning Outcomes
By completing this training, you will understand how to:

- Filter sequences using `Where`
- Sort using `OrderBy`, `ThenBy`, custom comparers
- Transform sequences using `Select`
- Work with anonymous types
- Combine multiple LINQ operators in real data scenarios
- Work with XML-based customer data

---

# 📘 Technologies & Concepts
- C# LINQ  
- Anonymous Types  
- Lambda Expressions  
- Filtering, Sorting, Projection  
- Working with Lists & XML data  
- Real-world product & customer datasets  

---

# ⚙ Requirements
- .NET SDK **6.0 or higher**  
- Visual Studio / VS Code / Rider  

---

## 👨‍💻 Author
**Abdalla Adel Aboaziz**  
Backend .NET Developer
