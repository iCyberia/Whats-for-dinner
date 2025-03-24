
# MenuAppBlazor

MenuAppBlazor is a web application that helps users manage their meal plans, ingredients, grocery lists, and upcoming menus. This app allows users to add dishes, store ingredients, and create an interactive list of upcoming meals. This app is under active development.

## Features

- **Add Dishes and Ingredients**: Create dishes with a list of ingredients, including a quantity and unit.
- **Upcoming Menu**: Display and manage upcoming menu items, with the ability to add a random meal from the list.
- **Grocery List**: Generate a grocery list based on the selected dishes and ingredients.

## Setup

### Prerequisites

1. Install **.NET SDK** (for building and running the app).
2. Install **Docker** (if you're using Docker to manage your containers).
3. Setup **SQL Server** for storing meal data and user information.

### Running the Application (Without Docker)

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/MenuAppBlazor.git
   cd MenuAppBlazor
   ```

2. Install dependencies:
   ```bash
   dotnet restore
   ```

3. Build and run the application:
   ```bash
   dotnet run
   ```

4. Open a browser and navigate to `http://localhost:5000` to access the app.

### Running the Application with Docker (Optional)

1. **Create a Docker Image** for the app:
   - Navigate to your project directory.
   - Build the Docker image:
   ```bash
   docker build -t menuapp .
   ```

2. **Run Docker Container**:
   - After building the Docker image, you can run it in a container:
   ```bash
   docker run -d -p 5000:80 menuapp
   ```
   - This will run the app in a container and expose port 5000 to your local machine.
   - Navigate to `http://localhost:5000` to access the app.

3. **Docker Compose Setup (Optional)**:
   If you use **Docker Compose** to manage your containers, create a `docker-compose.yml` file like this:

   ```yaml
   version: "3.1"

   services:
     menuapp:
       image: menuapp
       build:
         context: .
         dockerfile: Dockerfile
       ports:
         - "5000:80"
       environment:
         - DB_PASSWORD=${DB_PASSWORD}  # Use an environment variable for DB password
   ```

   - This setup allows you to manage multiple containers easily, such as running your application and database together.

4. **Running Docker Compose**:
   - Once you have your `docker-compose.yml` file ready, run the following command:
   ```bash
   docker-compose up -d
   ```
   - This will build and start all services defined in the `docker-compose.yml` file.

5. **Verify Everything Is Running**:
   - After running the Docker container or Compose setup, visit `http://localhost:5000` to check if the app is working.
   - You can use this command to verify the status of the container:
   ```bash
   docker ps
   ```

### Docker Secrets (Optional for Secure Password Handling)

If you want to securely store the database password using **Docker Secrets**, here’s how to do it:

1. **Create Docker Secret**:
   Create a secret for your database password:
   ```bash
   echo "YourSecurePassword" | docker secret create db_password -
   ```

2. **Modify the Docker Compose File**:
   Include the secret in your `docker-compose.yml`:
   ```yaml
   version: "3.1"

   services:
     menuapp:
       image: menuapp
       secrets:
         - db_password
       environment:
         - DB_PASSWORD_FILE=/run/secrets/db_password

   secrets:
     db_password:
       external: true
   ```

3. **Access the Secret in Your Application**:
   In your application, you can read the secret file from `/run/secrets/db_password`:
   ```csharp
   var password = File.ReadAllText("/run/secrets/db_password");
   var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString").Replace("${DB_PASSWORD}", password);
   builder.Services.AddDbContext<MenuContext>(options =>
       options.UseSqlServer(connectionString));
   ```

### Acknowledgements

- Thanks to all the contributors and libraries that made this app possible.
