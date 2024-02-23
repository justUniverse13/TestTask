Feature: SocialSharing

Social Sharing - integration with social media platforms to share campaigns.

Background: Login to Social Sharing page and validate page name
  Given User is login in using 'Testuser' account

@Functional @Integration
Scenario: User login and logout
  When User clicks on the logout link
  Then User see the login page 

