# 🚆 Railway Reservation System

A comprehensive **Railway Reservation System** built using **VB.NET** and **SQL Server**. This project simulates a real-world railway ticket booking system that allows users to book, cancel, and view train reservations, while providing administrators full control over train schedules and passenger management.

---

## 📌 Table of Contents

- [About the Project](#about-the-project)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Screenshots](#screenshots)
- [Database Schema](#database-schema)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

---

## 🧾 About the Project

The **Railway Reservation System** is a Windows-based desktop application that enables users to:

- Search trains between two stations.
- Book or cancel tickets.
- View booking history and ticket details.
- Perform administrative tasks like adding trains, updating schedules, and managing users.

This project can be used for learning database interaction, form design, and basic CRUD operations in VB.NET.

---

## ✨ Features

### 🧑‍💼 User Panel:
- Register and login
- Search trains by source and destination
- Book tickets
- View and cancel bookings
- View ticket status

### 🛠️ Admin Panel:
- Add, edit, and delete trains
- Manage routes and seat availability
- View all bookings
- Manage passengers

### 🧾 Other Functionalities:
- Automatic fare calculation
- Real-time seat availability
- Role-based access control

---

## 💻 Technologies Used

- **Frontend**: VB.NET (Windows Forms)
- **Backend**: SQL Server
- **Database Access**: ADO.NET
- **IDE**: Visual Studio

---

## 🖼️ Screenshots

> You can insert real screenshots after uploading them to the GitHub repo.

![Home Screen](screenshots/home.png)
*Main user dashboard*

![Admin Panel](screenshots/admin.png)
*Admin train management interface*

---

## 🗂️ Database Schema

**Main Tables:**
- `Users`: Stores login credentials and user details
- `Trains`: Contains train details
- `Reservations`: Stores ticket booking information
- `Routes`: Defines source, destination, and route-related info
- `Payments`: Payment status of each booking

You’ll find the database script in the `/DatabaseScripts` folder.

---

## ⚙️ Getting Started

### Prerequisites

- Visual Studio 2019 or later
- SQL Server or SQL Server Express
- .NET Framework 4.7.2 or compatible

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/Prahaladsingh221/RailwayReservationSystem.git
