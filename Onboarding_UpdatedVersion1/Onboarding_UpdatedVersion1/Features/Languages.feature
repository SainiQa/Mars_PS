Feature: Languages

As a Seller in Mars Application
I want to Add, Update and Delete my languages (with Valid data) in my Profile Details 
So that
The people seeking for some skills can look into my details.

@tag1

Scenario Outline:T01- Add Language with valid details on Profile Page 
	Given I logged into Mars application successfully
	When I add '<Language>', '<Level>'
	Then The record should display the added '<Language>' and '<Level>'
	Examples: 
    | Language | Level  |
	| Hindi    | Basic	|    
	| English  | Fluent |
    	
Scenario: T02- Update existing Language on Profile Page
	Given I logged into Mars application successfully
	When I  update Language and corresponding level on an existing language record
	Then Updated language record should be displayed on profile page 
	

Scenario: T03- Delete an existing Language on Profile Page
Given I logged into Mars application successfully
When I  delete an existing language record 
Then Language Record should be deleted and Deleted record should NOT be displayed on profile page 
