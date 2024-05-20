# comopundinterest
# Compound Interest Calculator

This is a simple Windows Forms application to calculate compound interest. The program takes user inputs for the principal amount, annual interest rate, time period (in years), and compounding frequency to compute the amount after interest.

## Features

- Calculate compound interest based on user input.
- Simple and intuitive user interface.
- Display the result in a read-only textbox.

## Getting Started

### Prerequisites

- Visual Studio (any recent version)
- .NET Framework

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/ULTRONLORD/compoundinterest.git
    ```

2. Open the project in Visual Studio:
    - Open Visual Studio.
    - Go to `File` > `Open` > `Project/Solution`.
    - Select the `.sln` file from the cloned repository.

3. Build and run the project:
    - Press `F5` or go to `Debug` > `Start Debugging`.

## Usage

1. **Principal Amount**: Enter the initial amount of money you want to invest or borrow.

2. **Annual Interest Rate**: Enter the annual interest rate as a decimal. For example, for a 5% interest rate, enter `0.05`.

3. **Time Period (Years)**: Enter the number of years the money will be invested or borrowed.

4. **Compounding Frequency**: Enter the number of times the interest is compounded per year:
    - Annually: `1`
    - Semi-annually (every 6 months): `2`
    - Quarterly (every 3 months): `4`
    - Monthly: `12`

5. Click the `Calculate` button to compute the amount after interest.

### Example

To calculate the amount for an initial investment of $1,000 at an annual interest rate of 5% over 3 years, compounded semi-annually:

- **Principal Amount**: `1000`
- **Annual Interest Rate**: `0.05`
- **Time Period (Years)**: `3`
- **Compounding Frequency**: `2`

Click the `Calculate` button. The result will be displayed in the "Result" textbox.

## Code Overview

The main calculation is handled in the `button1_Click` event handler:

```csharp
private void button1_Click(object sender, EventArgs e)
{
    double principal = double.Parse(principalTextBox1.Text);
    double rate = double.Parse(rateTextBox2.Text);
    double c = double.Parse(compoundingFrequencyTextBox3.Text);
    double time = double.Parse(timeTextBox4.Text);

    double amount = principal * Math.Pow(1 + (rate / c), c * time);

    resultTestBox5.Text = amount.ToString();
}
