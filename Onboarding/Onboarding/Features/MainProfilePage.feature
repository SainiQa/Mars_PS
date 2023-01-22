Feature: MainProfilePage

As a Seller in Mars Application
I want to add my Profile Details 
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

#Scenario: Delete profile name
#	Given I logged into Mars application successfully
#	When I delete First name and I delete Last name
#	Then  "First name and last name are required" message should be displayed.
	
Scenario: Add Availability
	Given I logged into Mars application successfully
	When I select an Availability option
	Then The selected availability should be displayed on profile page

	Scenario: Update an existing Availability
	Given I logged into Mars application successfully
	When I update the Availability option
	Then  The updated availability should be displayed on profile page.

	#Scenario: Delete Availability option
	#Given I logged into Mars application successfully
	#When I delete/deselect all the Availability option
	#Then I should not be able to delete availability

Scenario: Add Hours
	Given I logged into Mars application successfully
	When I select number of Hours in the profile page
	Then Selected Hours should be displayed on the profile page.

Scenario: Update existing Hours
	Given I logged into Mars application successfully
	When I update the existing number of Hours in the profile page
	Then The updated hours should be displayed on the profile page.

	#Scenario: Delete Hours 
	#Given I logged into Mars application successfully
	#When I delete/deselect all the hours option
	#Then I should not be able to delete/deselect availability

	
Scenario: Add Earn Target
	Given I logged into Mars application successfully
	When I select an Earn Target option 
	Then The selected Earn Target should be displayed on profile page 

Scenario: Update an existing Earn Target option
	Given I logged into Mars application successfully
	When I update an Earn Target option 
	Then The updated Earn Target should be displayed on profile page 
	#Scenario: Delete Earn Target 
	#Given I logged into Mars application successfully
	#When I delete/deselect all the Earn Target option
	#Then I should not be able to delete/deselect Earn Target

