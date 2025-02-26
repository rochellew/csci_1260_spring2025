def read_inventory(filename):
    inventory = {}
    try:
        with open(filename, 'r') as file:
            next(file) #skips header line
            for line in file:
                try:
                    room, item, quantity = line.strip().split(',')
                    quantity = int(quantity) # ensure that the quantity is a number
                    if room not in inventory:
                        inventory[room] = []
                    inventory[room].append((item, quantity))
                except ValueError: # if the quantity is NOT a number
                    print(f"Skipping malformed line {line.strip()}")
    # handle other exceptions
    except FileNotFoundError:
        print(f"Error: The file '{filename}' was not found...")
    except PermissionError:
        print(f"Error: Permission denied for '{filename}'...")
    except Exception as e: # a general exception
        print(f"Unexpected error: {e}")
    return inventory

def display_inventory(inventory):
    if not inventory:
        print("\nInventory is empty or could not be loaded...\n")
        return
    
    print("-"*30)
    print("\nBarbie's Dream House Inventory\n")
    print("-"*30)
    
    for room, items in inventory.items():
        print(f"{room}:")
        for item, quantity in items:
            print(f"    - {item} (x{quantity})")
    print("\n")
    
dream_house = read_inventory('dreamhouse.csv')
display_inventory(dream_house)

def add_item(inventory, room, item, quantity):
    try:
        quantity = int(quantity) # ensure quantity is a number
        if quantity < 1:
            raise ValueError("Quantity must be a non-negative integer greater than zero.") # throwing our own exception
        if room in inventory:
            for i, (existing_item, existing_quantity) in enumerate(inventory[room]):
                if existing_item == item:
                    inventory[room][i] = (existing_item, existing_quantity + quantity)
                    print(f"Updated {room}: {item} now has {existing_quantity + quantity}.")
                    return
                
            inventory[room].append((item, quantity))
        else:
            inventory[room] = [(item, quantity)]
            
            
        print(f"Added {quantity}x {item} to {room}")
    except ValueError:
        print(f"Error: Quantity of {item} must be a valid non-negative integer greater than zero.")
        
add_item(dream_house, "Kitchen", "Cupcake Maker", "1")
add_item(dream_house, "Garage", "Electric Scooter", "-5")
add_item(dream_house, "Kitchen", "Pink Blender", "3")
display_inventory(dream_house)

def save_inventory(filename, inventory):
    try:
        with open(filename, "w") as file:
            file.write("Room,Item,Quantity\n")
            for room, items in inventory.items():
                for item, quantity in items:
                    file.write(f"{room},{item},{quantity}\n")
        print("Inventory saved!!!")
    except PermissionError:
        print(f"Error: Permission denied for '{filename}'...")
    except Exception as e:
        print(f"Unexpected error: {e}")
        
# Save changes
save_inventory('dream_house2.csv', dream_house)