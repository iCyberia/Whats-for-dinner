# What's for dinner?

Whatsfordinner is a web application that helps users manage their meal plans, ingredients, grocery lists, and upcoming menus. This app allows users to add dishes, store ingredients, and create an interactive list of upcoming meals. This app is under active development.
![Screenshot](https://github.com/iCyberia/Whats-for-dinner/raw/main/img/Home.png)


## Features

- **Add Dishes and Ingredients**: Create dishes with a list of ingredients, including a quantity and unit.
![Screenshot](https://github.com/iCyberia/Whats-for-dinner/raw/main/img/addadish.png)

- **Upcoming Menu**: Display and manage upcoming menu items, with the ability to add a random meal from the list.
![Screenshot](https://github.com/iCyberia/Whats-for-dinner/raw/main/img/upcommingmenu.png)
 
- **Grocery List**: Generate a grocery list based on the selected dishes and ingredients.
![Screenshot](https://github.com/iCyberia/Whats-for-dinner/raw/main/img/grocerylist.png)



## Setup

### Prerequisites

1. Install **.NET SDK** (for building and running the app).
2. Install **Docker** (if you're using Docker to manage your containers).
3. Setup **SQL Server** for storing meal data and user information.

### Running the Application

Clone the repository:
   ```bash
   git clone https://github.com/iCyberia/Whats-for-dinner
   cd MenuAppBlazor
   ```


## To-Do List

- **User Authentication with Role-Based Access Control (RBAC)**: Implement user authentication with roles to control access to different parts of the app.
- **Custom Items for Grocery List**: Allow users to add custom items to the grocery list.
- **User Profile Page for Preferences**: Add a profile page where users can store preferences (e.g., theme).
- **Add Icons to Menu Items**: Add icons to menu items (e.g., dishes, ingredients) for better navigation.
- **Explore Layout Options**: Experiment with layout styles for improved UI/UX and responsiveness.
- **Add Delicious and Difficulty Ratings**: Implement ratings for meal items (deliciousness and difficulty).
- **Admin Screen for Meal Recommendation Logic**: Create an admin screen with sliders to adjust meal recommendations.
- **Protect Against XSS (Cross-Site Scripting)**: Implement measures to prevent Cross-Site Scripting vulnerabilities.
- **On the Grocery List page, combine quantity and unit**: Instead of "Chicken, 2, Lbs," display it as "Chicken, 2 Lbs."
- **On the Upcoming Menu page, replace the dropdown list to select a meal with a grid of buttons**: Display a grid of buttons (no more than 5 or 6 wide), one for each menu item, with meal photos on the button and remove the dropdown menu


### Acknowledgements

- Thanks to all the contributors and libraries that made this app possible.
