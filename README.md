# V_Project 20/3/19 - ~
#### Private repo for V-s Master Project ####
----------------------------------------------
##### Content #####
1. Customer Project Requirements
2. Planning
3. Requirements Analysis
4. Design
5. Testing
6. Deployment
7. Maintance
 
----------------------------------------------
### 1. Customer Project Requirements ###

1. Customer Project Analysis 
	- Who is the customer ?
	- What the buyer gets ?
2. RAW Project Description 

    Implement a Estate Rent Managment System. System is separated in three parts based on roles provided by system. The roles are - **not specified user** ( user that is not selected a role, not loged or fully registered ), a **personal** use user ( user that can manage owned or rented home), a **bussines user** ( selling agent / renteer / rent agent ). As a PERSONAL - the user must be able to add bills to the estete he ownes. As PERSONAL he must able to add other PERSONAL OR NOT PERSONAL users to the estate. As BUSSINESS user he must be able to post a ESTATE FOR SALE OR RENT and other users must find this post and chose what to do. In addition the P/B Users must have social network like page to see the posted B User offers. The Bussines user must have owne administration pannel, in other words part of system for compate busssines managment. System must be more like social network for posting estates for rent and selling. Based on roles the user can post or bye/become renter. User that are buying can get a home managment service. Every role must have extras and limitations that can be unlocked by paying for that service. So in the start of the system must be provided services for basic use and payed use.  
3. Key Futures
	1. Home Page - Not registered users display for public information ( displaying available public deals )
	2. About / Register / Contact pages
	1. Login/Logout Functionality
	2. Roles Selection on register
		1. Register - No role
		2. Personal
			1. With Estate Add
			2. With Estate add and send invitation to other users/ send invite mail
			3. Must have option for more then one estate
			4. Must have option for role change 
		3. Busines
			1. Owner
			2. Agent
	3. Home Page - For registered users
	4. Home Page - Specific for each role
	5. Roles Specification
		1. Public part ( not logged, visitors)
			1. All available rents - sells - dealers - renters
		2. Private part ( registered users, not selected role )
			1. All available rents - sells - dealers - renters
			2. And option for role selection
		3. Private part ( role selected )
			1. All available rents - sells - dealers - renters
		4. Personal role
			1. Add onother user
			2. Add bill
			3. Calculate all bils
			4. Pay bill - virtual
			5. Pay bills real - payed service
			6. Payment notifications via mail/sms - payed service
			5. Become Owner or Dealer - payed service
		5. Owner role
			1. Add estate 
			2. Find Dealer
			3. Post estate
			4. Manage estate / Manage selled or rented estate
			5. Send notifications for paying bills to estate - payed service
			6. Owner Dashboard - Simular to Dealer Dashboard - Payed service
		6. Dealer role
			1. Add estate
			2. Post estate
			3. Manage estate
			5. Send notifications for paying bills to estate - payed service
			6. Dealer Dashboard / Dealer Managment - payed service
4. Presentation
	1. Alpha Version - Basic Front end
	2. Beta Version - Modern Front-end
	3. Release - All Key futures and good looking user interface
	
### 2. Planing ###

#### 1. Alpha Version ####

1. Project analysis - the project will be split in two main cores.
	1. Social Network Core - consist of Estate/Dealer/Owner social network like presentation
	2. Management Core - consist of management for Personal/Rent/Owner/Dealer management  
#### BUILD 01 Social Network CORE ####

1. GOAL - Create home page that displays all public estates that are set to sell or rent ( give option for filtering sell/ renting ). Create pages for dealers and owners, about us and contact. After user click on estate, dealer or owner he can see complete details only if is registered. Create register as Seaker functionality. As Seeker the user can see complete details and can make an offer or contact with the estate owner/renter or dealer

##### B01.Public Part #####

1. Home Page - not registered
	1. Not registered user are going to be able to see all public estates
	2. Buy selecting from menu user can go to all estates, dealers list, owners list ( if the are public)
	3. User can click on estate or dealer ore owner and can see public details
	4. User can't make contact ore save to favorite if he is not registered
	5. User is prompt to Register or login if he want to see details
	5. User can see About / Contact /Register/ Login pages and can go to them

##### B01.Private Part #####

1. Register AS
	1. Seaker - user want's to only look, buy and contact owner or dealer	
		
### 3. B01.Requirements Analysis ###

1. Entities - Estate, Dealer, Owner, User
2. Display all public Estate, Dealer, Owner in separated pages
3. If user try to contact ore see more details is send to log in or register
4. Register gives options for selecting role
	
### 4. B01.Design ###

##### B01.Initial Start Design #####

0. Creating Folder Structure
1. Presentation layer Asp .Net Core 2.2 MVC 
2. Data Base Layer - Entity Framework and MS SQL Database
3. Identity System - Asp .NET Core Identity 2.2
4. Models - Estate, Dealer, Owner, User ( note for IsDeleted and IsPublic Fields )
5. Filling DB with test data for displaying in Home page
6. Setting up _Layeaut to use Menu Component for Seaker role 
7. When user is registered he must get role - Seaker
8. Find a way to make private chat with Seaker-Seler - build messaging system

#############################################

#### BUILD 02 ####

##### B02.Private Part #####

1. Register AS	
	2. Personal - Seaker + Personal account
	3. Bisuness - Owner
	4. Business - Dealer
		
### 4. B02.Design ###

### 5. Testing ###