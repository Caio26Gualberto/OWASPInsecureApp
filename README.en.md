# OWASP Vulnerabilities Demo - ASP.NET Core MVC

This project was developed for educational purposes to demonstrate the main vulnerabilities listed by OWASP (Open Worldwide Application Security Project), using the ASP.NET Core MVC stack. It simulates real-world scenarios where these flaws can occur, with the intention of demonstrating both exploitation and prevention of these flaws.

> ⚠️ Warning: This project contains intentionally implemented vulnerabilities and should not be used in production.

---

📄 This README is available in other languages:
- 🇧🇷 [Português](README.pt-br.md)
- 🇺🇸 English (you are here)

## ✅ Vulnerabilities Addressed

1. SQL Injection
Attack simulation using SQL commands in input fields. Demonstrates how a lack of parameterization in queries can compromise the entire database.

2. Cross-Site Scripting (XSS)
Demonstrates how malicious scripts can be injected and executed in the victim's browser.

3. **Cross-Site Request Forgery (CSRF)**
Exhibits how an attacker can forge requests on behalf of an authenticated user without the user's knowledge.

4. **Insecure Direct Object References (IDOR)**
Exhibits how to access other users' resources by changing IDs directly in the URL.

5. **Security Misconfiguration**
Simulates an environment where incorrect or permissive configurations can expose sensitive information or allow unauthorized access.

6. **Sensitive Data Exposure**
Exhibits bad practices such as storing passwords in plaintext or the lack of HTTPS.

7. **Unvalidated Redirects and Forwards**
Exhibits how unvalidated redirects can be exploited for phishing attacks.

8. **Command Injection**
Exploits the execution of system commands via user input, potentially leading to arbitrary code execution on the server.

---

## 📂 Project Organization

- The project is structured using standard ASP.NET MVC Controllers and Views.
- Each vulnerability has its own route and a **view with an explanatory label**.
- Technical explanations for each flaw are available in the **frontend (views)** and in the **backend code comments**, facilitating the isolated study of each case.

---
## 🛡️ Why study these flaws?

Currently, many modern languages, frameworks, and libraries already **automatically** handle various security aspects such as:
- Input validation
- Password encryption
- XSS/CSRF protections
- Authentication/authorization middleware
- LGPD/GDPR compliance

However, understanding these vulnerabilities is essential for:

- Cases where we use new languages or frameworks that **do not have native protection**. - When we need to **write our own authentication, encryption, or validation middleware**.
- To be able to **recognize flaws in legacy or third-party code**.

---
## 🧠 Objective

The main objective of this repository is to **teach through practice**. By exploring each vulnerability in this controlled environment, you will be able to:
- Identify flaws in real applications
- Understand how they work in practice
- Know how to prevent them with good development practices

---

## 🚀 How to run

1. Clone the repository:
```bash
git clone https://github.com/your-user/OWASP-Demo-App.git
