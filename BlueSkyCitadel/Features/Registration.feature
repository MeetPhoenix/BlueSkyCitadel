Feature: Registration
    As a user of https://user-68906616-work.colibriwp.com/bluesky-citadel/ I
	I want to register on the website
	So that I can buy blueSky citadel products

Rule: Every external user should be able to Register on the website

@my819
Scenario: Valid Registration
    Given I navigate to blueskycitadel.com
    When I click on My Account
	And I enter Username "Feeniks"
	And I enter Password "Mixmax"
	And I enter Confirm Password "Mixmax"
	And I enter Full Name "Feeniks Asce"
	And I enter Email Address "alt.gq-couh0r48@yopmail.com"
	And I enter Phone Number "07155622926"
	And I select Nigeria as Country from the drop down menu
	And I click on the Register button
 	Then the successful message "Account registration successful. Click here to login to your account" is displayed on the page