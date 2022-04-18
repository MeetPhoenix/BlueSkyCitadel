Feature: RegisterNewUser
     As a user of https://user-68906616-work.colibriwp.com/bluesky-citadel/#about
     I want the current registration page to be improved upon
     So that I can see a user friendly and attractive Register With Us page
	
Rule: User should be able to view the Regidter New User Page on BlueSkyCitadel

@758
Scenario: Verify Register New User Page
	Given i navigate to blueskycitadel.com
	When I click on My Account button 
	Then i should be able to view the Register With Us page