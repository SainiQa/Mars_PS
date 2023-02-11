Feature: ProfilePagePositiveTests

As a Seller in Mars Application
I want to Add and Update my Name,Availabilty,Number of Hours and Target in  Profile Details  (with Valid Data)
So that
The people seeking for some skills can look into my details.

@tag1

Scenario Outline: Add profile name with valid credentials.
	Given I logged into Mars application successfully.
	When add avalid  <First name> and <Last name>
	Then The profile page should display the profile name "<First name>  <Last name>" successfully.
Examples: 
| First name | Last name |
| Pooja      | Saini     |

	
Scenario: Add Availability
	Given I logged into Mars application successfully
	When I select an Availability option
	Then The selected availability should be displayed on profile page

	Scenario: Update an existing Availability
	Given I logged into Mars application successfully
	When I update the Availability option
	Then  The updated availability should be displayed on profile page.
	

Scenario: Add Hours
	Given I logged into Mars application successfully
	When I select number of Hours in the profile page
	Then Selected Hours should be displayed on the profile page.

Scenario: Update existing Hours
	Given I logged into Mars application successfully
	When I update the existing number of Hours in the profile page
	Then The updated hours should be displayed on the profile page.
	
	
Scenario: Add Earn Target
	Given I logged into Mars application successfully
	When I select an Earn Target option 
	Then The selected Earn Target should be displayed on profile page 

Scenario: Update an existing Earn Target option
	Given I logged into Mars application successfully
	When I update an Earn Target option 
	Then The updated Earn Target should be displayed on profile page 
	
