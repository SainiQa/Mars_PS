Feature: 1Language

As a Seller in Mars Application
I want to add, update and delete my languages in my Profile Details 
So that
The people seeking for some skills can look into my details.

@tag1

Scenario Outline:Add Language with valid details on Profile Page 
	Given I logged into Mars application successfully
	When I add '<Language>', '<Level>'
	Then Added language record should be successfully added on profile page

	Examples: 
    | Language | Level  |
    | English  | Fluent |
    | Hindi    | Basic |
	| Punjabi  | Basic |
	
	
Scenario:Update existing Language on Profile Page
	Given I logged into Mars application successfully
	When I  update Language and corresponding level on an existing language record
	Then Updated language record should be displayed on profile page 
	

Scenario:Delete an existing Language on Profile Page
Given I logged into Mars application successfully
When I  delete an existing language record 
Then Language Record should be deleted and Deleted record should NOT be displayed on profile page 
