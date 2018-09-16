Feature: Login
	Test the Properties functionality of the application
	verify if the login as owner are working as expected
Scenario Outline: Verify if the owner is able to add property details,financial and tenant details.
	Given I navigate to keys web application 
	And I  type  "<username>", "<password>" 
	When I click login button
	Then I should be able to login successfully and Dasboard page should be displayed
	When I click on Owners and click on the Properties button
	Then I should navigate to My properties Page	
	When I click on the Add New Property Button 
	Then I should be on the Add New Properties Details Page	
	When I enter all the mandatory fields "<property>", "<streetNumber>", "<route>","<City>", "<post>", "<region>","<desc>","<rent>","<bedroom>", "<bath>", "<car>","<built>" and click on Next button
	Then I should Navigate to Financial Details Page	
	When i enter all the required fields for Financial Details "<pprice>", "<mprice>", "<hvalue>", "<repayment>", "<repaystart>","<expenseamt>", "<expensedesc>", "<expensedate>" and click on Next Button
	Then I should navigate to Add Tenant Details Page	
	When I entered all the mandatory fields in the Tenant Details Page "<email>", "<fname>", "<lname>", "<sdate>", "<edate>", "<ramt>", "<psdate>" and click Save button
	Then I should see all the entered values saved.		
Examples: 
| testcase | username          | password  | property    | streetNumber | route            | City		| post | region | desc                          | rent | bedroom | bath | car | built | pprice | mprice | hvalue | repayment | repaystart | expenseamt | expensedesc                    | expensedate | email           | fname | lname | sdate      | edate      | ramt | psdate     |
| 1        | vvpveed@gmail.com | harii@123 | Rose Garden | 36           | campbell street  | sydney		| 2020 | NSW    | spacious and no commonn walls | 500  | 2       | 1    | 1   | 2015  | 500000 | 400000 | 600000 | 1000      | 22/12/2017 | 5000       | electric fitting for the house | 22/10/2015  | sugar@gmail.com | Peter | John  | 22/01/2018 | 22/01/2019 | 500  | 22/01/2018 |
| 2        | vvpveed@gmail.com | harii@123 | Sun City    | 45           | cambridge street | perth		| 2021 | WA     | Best for nature lovers        | 400  | 1       | 1    | 1   | 2016  | 400000 | 300000 | 400000 | 900       | 22/11/2017 | 4000       | overall furnishing and labour  | 22/10/2016  | sugar@gmail.com | Emily | Joe   | 22/01/2017 | 22/01/2018 | 400  | 22/01/2017 |
| 3        | vvpveed@gmail.com | harii@123 | Metro Elite | 65           | ilford street    | queensland	| 2023 | BNE    | sutalbe for all age groups	| 700  | 4       | 3    | 2   | 2018  | 900000 | 800000 | 700000 | 2000      | 22/01/2018 | 3000       | electric fitting for the house | 22/10/2017  |  sugar@gmail.com| Jacob | Justin| 22/10/2017 | 22/10/2018 | 700  |22/10/2017  |
| 4        | vvpveed@gmail.com | harii@123 | Palace city | 25           | westham street   | darwin		| 2024 | NT	    | lots of free space and parks	| 600  | 3       | 2    | 1   | 2014  | 800000 | 600000 | 900000 | 600	     | 22/12/2015 | 8000       | Maintenance charges			| 22/10/2017  | sugar@gmail.com | Peter | John  | 22/01/2018 | 22/01/2019 | 600  | 22/01/2018 |
| 5		   | vvpveed@gmail.com | harii@123 | Metro Elite | 65           | ilford street	   | queensland	| 2023 | BNE    | sutalbe for all age groups	| 700  | 4       | 3    | 2   | 2018  | 900000 | 800000 | 700000 | 2000      | 22/01/2018 | 3000       | electric fitting for the house | 22/10/2017  |  sugar@gmail.com| Jacob | Justin| 22/10/2017 | 22/10/2018 | 700  |22/10/2017  |					


