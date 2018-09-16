Feature: ListARentals
	Validate the listing of a property as rental
	


Scenario Outline: Validate to see if the owner can list his property for rental 
	Given user is in the application 
	And user logs in the applicatipn by typing  "<username>", "<password>" 
	When user clicks on list rentals button and types "<property>", "<title>", "<Desc>", "<cost>", "<rent>", "<date>","<count>", "<petsallowed>" and click Save button
	Then users property is listed as rental.		
Examples: 
| testcase | username          | password  | property                    | title              | Desc               | cost | rent | date       | count | petsallowed |
| 1        | vvpveed@gmail.com | harii@123 | 65 ilford street,queensland | Affordable Housing | Affordable Housing | 2000 | 500  | 22/10/2017 | 4     | No          |

