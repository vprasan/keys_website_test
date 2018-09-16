Feature: DeleteProperty
		Validate to see if the owner can delete his proprety
	
Scenario Outline: validate to see if the owner can delete his property
	Given user is logged in the application with credentials "<username>", "<password>" 
	When user clicks on the delete property button in the property page
	Then the selected property will be deleted from the owners property.
Examples: 
| testcase | username          | password  |
| 1        | vvpveed@gmail.com | harii@123 |