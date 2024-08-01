# Shopping_list
### Technologies: C# .Net8 ,React.js, Sql Server
### Additional libraries: MUI
** More:  redux ,Axios etc,React DOM,Testing Libraries:...**
### To install the project you need:

Download the 2 projects
After downloading you must write the command: npm i
In the "Frontend" project: then run in the terminal: npm start
In the "Server" Install Dependencies: Run the command:dotnet restorea and then Run the command dotnet build

Now all that remains is to watch and enter data

When a user enters the application, they have a text field where they can type the name of a product. They then need to select a category for the product. As an added feature, the user can optionally choose a quantity. If no quantity is selected, the default is set to 1. The selected quantity is displayed next to the product, as shown in the accompanying illustration.
![image](https://github.com/user-attachments/assets/a2a6b66d-8781-4333-ac5e-b01d8d3db313)

When the user clicks "Add Product," the product and the selected quantity (or the default quantity if not selected) are displayed at the bottom of the page under the corresponding category. Next to each category name, the total quantity of all products under that category is displayed.
![image](https://github.com/user-attachments/assets/e9fc6d0c-8ecb-46d6-9465-316dfcb15e27)

Additionally, there is a field that continuously shows the total quantity of all products the user has added. The shopping cart is synchronized to display the total number of items.![image]![image]![image](https://github.com/user-attachments/assets/4a13f3cc-9aeb-4806-9929-a25fa133aaeb)

An upgrade I've made to the application includes the ability for the user to adjust the quantity of a product next to the product name, either increasing or decreasing the quantity in increments of one. This is done through buttons that allow the user to add or remove units.
![image](https://github.com/user-attachments/assets/5245a720-6135-4437-ad56-3aeb957ecea2)

When the user clicks "Complete Order," the order is finalized, and the list of products is sent to the server.
![image](https://github.com/user-attachments/assets/6e92bec0-999e-4f35-aad8-bc8d1e541f5b)

When the user clicks 'Complete Order' and there are no items in the order, they will receive a notification
![image](https://github.com/user-attachments/assets/9f8b3325-6b76-4b51-9813-aa4d1fbb97de)

Additionally, there is a product search field currently under development.
![Uploading image.png…]()

I've enhanced the application by managing all data within the store. Although refreshing the page would typically clear the data, I've implemented a feature that saves the data to Local Storage. This way, even if the user refreshes the page, the selected products remain as long as the "Complete Order" button hasn't been clicked.

Additionally, there is a product search field currently under development.

Let me know if there's anything you'd like to adjust or add!


