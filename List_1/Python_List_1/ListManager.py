class ListManager:
    def __init__(self):
        self.list = []

    def display_menu(self):
        print("""
        A menu of options:
        Press 1 to add an element to the end of the list.
        Press 2 to delete an element at a given location.
        Press 3 to delete an element from a given location.
        Press 4 to display all of the list elements.
        Press 5 to count the number of elements in the list.
        Press 6 to clear (initialize) the list.
        Press 7 to exit the program.
        """)


