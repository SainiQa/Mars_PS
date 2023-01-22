Feature: 3Education

As a Seller in Mars Application
I want to add, update and delete Education in my Profile Details 
So that
The people seeking for some skills can look into my details.

@tag1
Scenario:Add Education on profile page with valid data 
	Given I logged into Mars application successfully
	When I add  '<College>','<Country>', '<Title>', '<Degree>'and'<Year of Graduation>'
	Then Education record should be displayed in the list under Education tab on profile page
	Examples:
	| College | Country     | Title  | Degree     | Year of Graduation |
	| AUT     | New Zealand | B.Tech | Graduation | 2020               | 
	
Scenario:Update an existing Education record 
	Given I logged into Mars application successfully
	When I update College,Country,Title,Degree and Year of Graduation in an existing education record
	Then Updated education record should be displayed in the list under Education tab on profile page
	
	
Scenario:Delete an existing Education record 
	Given I logged into Mars application successfully
	When I delete an existing education record
	Then The record should be  deleted and should NOT be displayed in the list
