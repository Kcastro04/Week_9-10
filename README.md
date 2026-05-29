# Crystal Reports Receipt and Dashboard Home Form

## Laboratory Activity: Week 9–10

Prepared By: Kharellyn Joyce I. Castro  
Course: Bachelor of Science in Information Technology  
Instructor: Edward James V. Grageda  

---

# Project Overview

This project is a Windows Forms Application developed using C# and Visual Studio.  
The activity is divided into two parts:

- Part A – Crystal Reports Receipt
- Part B – Dashboard Home Form

The purpose of this project is to demonstrate the use of Crystal Reports for receipt generation and Dashboard UI Design using Windows Forms Application.

---

# Objectives

The objectives of this laboratory activity are:

- Create a Crystal Report Receipt
- Use Inventory DataSet
- Add Item, Quantity, Price, and Total Fields
- Compute Grand Total
- Display Report using CrystalReportViewer
- Create an MDI Parent Dashboard Form
- Design Left Navigation Panel
- Create KPI Statistic Cards
- Apply Consistent Color Theme
- Implement Navigation Buttons

---

# Tools and Technologies Used

| Technology | Description |
|------------|-------------|
| Visual Studio 2022 | IDE used for development |
| C# | Programming Language |
| Windows Forms | GUI Framework |
| Crystal Reports | Reporting Tool |
| .NET Framework | Application Framework |
| SQL Server / DataSet | Data Storage |

---

# Part A – Crystal Reports Receipt

## Description

This part of the project focuses on creating a receipt using Crystal Reports.  
The report retrieves data from the Inventory DataSet and displays item details including:

- Item Name
- Quantity
- Price
- Total Amount
- Grand Total

The report is embedded into a Windows Form using CrystalReportViewer.

---

# Features

- Crystal Report (.rpt)
- Inventory DataSet Integration
- Receipt Layout Design
- Automatic Total Computation
- Grand Total Formula
- CrystalReportViewer Preview

---

# Steps Performed

## Step 1 – Create New Crystal Report

1. Open Visual Studio
2. Right Click Project
3. Select Add > New Item
4. Choose Crystal Report
5. Name the file:
   CrystalReport1.rpt

---

## Step 2 – Add Inventory DataSet

Create a DataSet containing:

- ItemName
- Quantity
- Price
- Total

---

## Step 3 – Insert Fields

Drag and drop the following fields into the report:

- ItemName
- Quantity
- Price
- Total

---

## Step 4 – Add Grand Total

Insert a summary field to compute the Grand Total.

Formula:

```text
Sum ({Inventory.Total})
```

---

## Step 5 – Create Viewer Form

Add CrystalReportViewer into Form1.

---

## Step 6 – Load Report

Use the following code:

```csharp
using System;
using System.Windows.Forms;

namespace CrystalReceipt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrystalReport1 rpt = new CrystalReport1();

            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
```

---

# Sample Receipt Output

```text
==================================================
                 SALES RECEIPT
==================================================

Item Name          Qty      Price       Total
--------------------------------------------------
Mouse               2        250         500
Keyboard            1        750         750
Monitor             1       5500        5500

--------------------------------------------------
Grand Total:                    6750
--------------------------------------------------

Thank you for your purchase!
```

---

# Part B – Dashboard Home Form

## Description

This part of the project focuses on creating a Dashboard Home Form using Windows Forms Application.

The dashboard acts as the Main Menu of the system and contains:

- Navigation Sidebar
- KPI Statistic Cards
- Navigation Buttons
- MDI Parent Form
- Consistent Theme Design

---

# Dashboard Features

- MDI Parent Form
- Left Navigation Panel
- Dashboard Cards
- Responsive Layout
- Navigation Buttons
- Modern User Interface

---

# Dashboard Components

## Left Navigation Panel

Contains buttons for:

- Home
- Reports
- Inventory
- Students
- Settings
- Logout

---

## KPI Cards

### Card 1 – Total Sales
Displays total sales amount.

### Card 2 – Total Students
Displays total number of students.

### Card 3 – Total Inventory
Displays total inventory count.

---

# Dashboard Layout

```text
 ---------------------------------------------------------
| Navigation Panel |          Dashboard Area             |
|---------------------------------------------------------|
| Home             |   Total Sales:      15,000          |
| Reports          |   Total Students:   350             |
| Inventory        |   Total Inventory:  120             |
| Students         |                                     |
| Logout           |                                     |
 ---------------------------------------------------------
```

---

# Sample Dashboard Code

## MDI Parent Form

```csharp
using System;
using System.Windows.Forms;

namespace DashboardSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.MdiParent = this;
            home.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm report = new ReportsForm();
            report.MdiParent = this;
            report.Show();
        }
    }
}
```

---

# Dashboard Design Theme

## Color Palette

| Color | Purpose |
|-------|----------|
| Dark Blue | Main Background |
| Cyan Blue | Dashboard Panels |
| White | Text |
| Yellow | Highlight Accent |

---

# User Interface Design

The system uses a modern dashboard design inspired by business management systems.

Design Principles Used:

- Consistent spacing
- Modern color palette
- Organized navigation
- Readable typography
- Clean interface

---

# Learning Outcomes

After completing this activity, the student learned how to:

- Create Crystal Reports
- Use DataSets
- Design receipt reports
- Create MDI Applications
- Implement Dashboard Interfaces
- Use Navigation Panels
- Handle Form Events
- Improve UI/UX Design

---

# Advantages of the System

- Easy to use
- Organized dashboard interface
- Fast report generation
- User-friendly design
- Professional receipt output

---

# System Requirements

## Software Requirements

- Visual Studio 2022
- Crystal Reports for Visual Studio
- .NET Framework
- Windows OS

---

# Installation Guide

## Step 1

Install Visual Studio 2022.

---

## Step 2

Install SAP Crystal Reports Runtime.

---

## Step 3

Clone or download the repository.

---

## Step 4

Open the solution file (.sln).

---

## Step 5

Build and run the project.

---

# File Structure

```plaintext
CrystalReportsDashboard/
│
├── CrystalReport1.rpt
├── InventoryDataSet.xsd
├── Form1.cs
├── Dashboard.cs
├── HomeForm.cs
├── ReportsForm.cs
├── Program.cs
├── App.config
├── README.md
│
├── bin/
├── obj/
└── Properties/
```

---

# Screenshots

## Part A – Crystal Reports Receipt

Displays receipt report with:

- Item Details
- Quantity
- Price
- Total
- Grand Total

---

## Part B – Dashboard Home Form

Displays:

- Sidebar Navigation
- KPI Cards
- Dashboard Layout
- Navigation Buttons

---

# Common Errors and Solutions

## Error 1 – Crystal Report Not Loading

### Solution

Check if Crystal Reports Runtime is installed.

---

## Error 2 – Missing DataSet

### Solution

Ensure InventoryDataSet is properly connected.

---

## Error 3 – Viewer Blank

### Solution

Set the ReportSource correctly.

Example:

```csharp
crystalReportViewer1.ReportSource = rpt;
```

---

# Conclusion

This laboratory activity successfully demonstrates the integration of Crystal Reports and Dashboard Home Form using C# Windows Forms Application.

The project improved knowledge and skills in:

- Windows Forms Development
- Crystal Reports
- User Interface Design
- Dashboard Development
- Event Handling
- MDI Applications

The system provides an organized and professional interface suitable for inventory and reporting systems.

---

# Author

Kharellyn Joyce I. Castro

---

# Submitted To

Edward James V. Grageda

---

# Course

Bachelor of Science in Information Technology

---

# License

This project is for educational purposes only.
