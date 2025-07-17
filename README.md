# OWASP Vulnerabilities Demo - ASP.NET Core MVC

Este projeto foi desenvolvido com o propósito **educacional** para demonstrar as principais vulnerabilidades listadas pelo OWASP (Open Worldwide Application Security Project), utilizando a stack **ASP.NET Core MVC**. Ele simula cenários reais onde essas falhas podem ocorrer, com a intenção de mostrar tanto a exploração quanto a prevenção dessas brechas.

> ⚠️ **Atenção**: Este projeto contém vulnerabilidades propositalmente implementadas e **não deve ser usado em produção**.

---

📄 Este README está disponível em outros idiomas:
- 🇺🇸 [English](README.en.md)
- 🇧🇷 Português (você está aqui)

## ✅ Vulnerabilidades Abordadas

1. **SQL Injection**  
   Simulação de ataque inserindo comandos SQL em campos de input. Demonstra como a falta de parametrização nas queries pode comprometer todo o banco de dados.

2. **Cross-Site Scripting (XSS)**  
   Demonstra como scripts maliciosos podem ser injetados e executados no navegador da vítima.

3. **Cross-Site Request Forgery (CSRF)**  
   Exibe como um atacante pode forjar requisições em nome de um usuário autenticado, sem que ele perceba.

4. **Insecure Direct Object References (IDOR)**  
   Mostra como acessar recursos de outros usuários alterando IDs diretamente na URL.

5. **Security Misconfiguration**  
   Simula um ambiente onde configurações incorretas ou permissivas podem expor informações sensíveis ou permitir acesso indevido.

6. **Sensitive Data Exposure**  
   Demonstra práticas ruins como o armazenamento de senhas em texto plano ou a falta de HTTPS.

7. **Unvalidated Redirects and Forwards**  
   Mostra como redirecionamentos sem validação podem ser explorados para ataques de phishing.

8. **Command Injection**  
   Explora a execução de comandos do sistema via inputs de usuário, podendo levar à execução arbitrária no servidor.

---

## 📂 Organização do Projeto

- O projeto está estruturado em Controllers e Views padrão do ASP.NET MVC.
- Cada vulnerabilidade tem uma rota própria e uma **view com rótulo explicativo**.
- As explicações técnicas de cada falha estão no **frontend (views)** e nos **comentários do código backend**, facilitando o estudo isolado de cada caso.

---

## 🛡️ Por que estudar essas falhas?

Atualmente, muitas linguagens modernas, frameworks e bibliotecas já **tratam automaticamente** diversos aspectos de segurança como:
- Validação de input
- Criptografia de senhas
- Proteções contra XSS/CSRF
- Middlewares de autenticação/autorização
- Conformidade com LGPD/GDPR

No entanto, entender essas vulnerabilidades é fundamental para:

- Casos em que usamos linguagens ou frameworks novos que **não possuem proteção nativa**.
- Quando precisamos **escrever nossos próprios middlewares** de autenticação, criptografia ou validação.
- Para ser capaz de **reconhecer falhas em código legado** ou de terceiros.

---

## 🧠 Objetivo

O principal objetivo deste repositório é **ensinar através da prática**. Ao explorar cada vulnerabilidade neste ambiente controlado, você será capaz de:
- Identificar falhas em aplicações reais
- Compreender como elas funcionam na prática
- Saber como preveni-las com boas práticas de desenvolvimento

---

## 🚀 Como rodar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/OWASP-Demo-App.git
