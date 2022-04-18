Feature: AboutUs
    As a user of https://user-68906616-work.colibriwp.com/bluesky-citadel/#about
    I want to see the content in the About Us section
    So that I can find out more about BlueSky Citadel
	
Rule: User should be find out more about BlueSkyCitadel

@190
Scenario: Verify About Us button
	Given i navigate to blueskycitadel.com
	When i click on About Us button
	Then i should be Redirected to the About Us section of the home page
