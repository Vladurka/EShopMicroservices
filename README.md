# 🛒 Online Store on Microservices (.NET)

## 📌 Project Description
This project is an online store developed using a microservices architecture on the .NET platform. It allows users to browse the product catalog, add items to the cart, and place orders.

## ⚙️ Key Features
- Product catalog management
- Adding and removing items from the cart
- Order placement and tracking

## 🏗️ Technologies
The project uses modern technologies:
- **Backend:** .NET 8 (ASP.NET Core Web API)
- **Database:** PostgreSQL, Marten, SQL Server, Redis
- **API Gateway:** YARP
- **Containerization:** Docker
- **Messaging:** RabbitMQ

## 📂 Architecture
The project consists of multiple microservices:
- **Product Catalog** – managing products and categories (Vertical slice architecture, CQRS)
- **Cart** – storing items added by users (Vertical slice architecture, CQRS)
- **Orders** – processing and managing orders (Clean architecture, CQRS, DDD)
- **API Gateway** – request routing

## 🎯 Project Goal
To create a convenient and scalable online store that ensures high performance, reliability, and ease of use for both customers and administrators.
