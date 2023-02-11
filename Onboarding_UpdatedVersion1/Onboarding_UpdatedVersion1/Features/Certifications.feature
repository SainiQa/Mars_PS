Feature: Certifications

As a Seller in Mars Application
I want to Add, Update and Delete Certifications (with Valid Data) in  my Profile Details 
So that
The people seeking for some skills can look into my details.

@tag1
Scenario: 1 Add Certificate with valid details on Profile Page 
	Given I logged into Mars application successfully
	When I add Certficate, Certificatefrom and Year
	Then Certificate record should be successfully added on profile page
   

Scenario: 2 Update an existing Certification on profile page
	Given I logged into Mars application successfully
	When I  update Certificate,Certificate from and the Year
	Then Certification record should be updated and displayed on profile page 
	
Scenario: 3 Delete an existing Certification on profile page
	Given I logged into Mars application successfully
	When I  delete an existing certification record
	Then The record should be  deleted and should NOT be displayed in the list
