Feature: 4Certifications

As a Seller in Mars Application
I want to add, update and delete Certifications in  my Profile Details 
So that
The people seeking for some skills can look into my details.

@tag1
Scenario:Add Certifications on profile page, with valid data.
	Given I logged into Mars application successfully
	When I added '<Certificate>','<Certificate From>' and '<Year>'
	Then Certification record should be added successfully.
	Examples: 
	| Certificate					| Certificate from   |  Year  |
	| Salesforce Administrator		| Salesforce		 |  2020  | 

Scenario:Update an existing Certification on profile page
	Given I logged into Mars application successfully
	When I  update Certificate,Certificate from and the Year
	Then Certification record should be updated and displayed on profile page 
	
Scenario:Delete an existing Certification on profile page
	Given I logged into Mars application successfully
	When I  delete an existing certification record
	Then The record should be  deleted and should NOT be displayed in the list

