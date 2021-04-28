CREATE TABLE CITypes(
TypeID INT PRIMARY KEY,
TypeName VARCHAR(50));

CREATE TABLE CIs(
CI_ID INT PRIMARY KEY IDENTITY (1,1),
TypeID INT,
AttributeMappingID INT,
CustomerID INT,
ServiceID INT);

CREATE TABLE Attributes(
AttributeID INT PRIMARY KEY,
AttributeName VARCHAR(50),
StringValue VARCHAR(50),
TemplateName VARCHAR(50),
AttributeMappingID INT);

CREATE TABLE CIAttributeMapping(
AttributeMappingID INT PRIMARY KEY,
AtrtibuteValue VARCHAR(50),
CI_ID INT,
AttributeID INT);

CREATE TABLE Customers(
CustomerID INT PRIMARY KEY,
CustomerName VARCHAR(50));

CREATE TABLE CIServices(
ServiceID INT PRIMARY KEY,
ServiceValue VARCHAR(50),
EmployeeID INT);

CREATE TABLE Employees(
EmployeeID INT PRIMARY KEY,
EmpName VARCHAR(50)); 


ALTER TABLE CIs ADD FOREIGN KEY (TypeID) REFERENCES CITypes(TypeID)
ALTER TABLE CIs ADD FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
ALTER TABLE CIs ADD FOREIGN KEY (ServiceID) REFERENCES CIServices(ServiceID)
ALTER TABLE CIServices ADD FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
ALTER TABLE CIs ADD FOREIGN KEY (AttributeMappingID) REFERENCES CIAttributeMapping(AttributeMappingID)
ALTER TABLE Attributes ADD FOREIGN KEY (AttributeMappingID) REFERENCES CIAttributeMapping(AttributeMappingID)