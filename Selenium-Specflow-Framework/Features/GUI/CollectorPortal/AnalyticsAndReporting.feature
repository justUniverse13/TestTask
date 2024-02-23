Feature: AnalyticsAndReporting

Background: Login to Analytics and Reportion page and validate page name
  Given User is login in using 'Testuser' account

@Functional @Integration
Scenario: User login and logout
  When User clicks on the logout link
  Then User see the Analytics and Reporting page  
