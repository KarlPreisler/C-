/*
 * 3 Ett företag har namn, adress, telefonnummer, faxnummer, hemsida och chef. 
 * Chefen har förnamn, efternamn, e-postadress och telefonnummer. 
 * Skriv ett program som läser informationen om företaget och chefen och skriver dem 
 * till konsolen.
 */

Company Telerik = new Company()
{
    Name = "Telerik",
    Address = "Sofia",
    PhoneNumber = "052/123456",
    FaxNumber = "0700/123456",
    WebSite = "http://telerik.com"
};

Telerik.Manager = new Company.CManager
{
    FirstName = "Svetlin",
    LastName = "Nakov",
    Age = 34,
    PhoneNumber = "0888 123 456"
};

// Print information
Telerik.PrintInformation();
Telerik.Manager.PrintInformation();

// NEW COMPANY ->
Company userCompany = new Company(); // Declaration
userCompany.InputData(); // Initialization

userCompany.Manager = new Company.CManager(); // Declaration
userCompany.Manager.InputData(); // Initialization

// Print information
userCompany.PrintInformation();
userCompany.Manager.PrintInformation();
