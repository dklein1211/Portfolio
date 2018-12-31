"""
Interface Commands:
-Enter a to add a movie
-Enter l to see your movies
-Enter f to find a movie
-Enter q to quit

Tasks:
[X]: Store movie data
[X]: What is the format of a movie?
[X]: Show the user the main interface and get their input
[X]: Allow users to add movies
[X]: Show all their moves
[]: Find a movie
[X]: Stop running the program

"""

data_movies = []  # Stores all of the data

# data_movies = [{'name': 'Movie1', 'director': 'Dic1', 'year': 'Year1'},{'name': 'Movie2', 'director': 'Dic2', 'year': 'Year2'}]


def menu():
    user_input = input("\nInterface Commands: a adds a movie, l to see your movies, f to find a movie, q to quit\n")

    while user_input != 'q':
        if user_input == 'a':
            add_movie()
        elif user_input == 'l':
            show_movies(data_movies)
        elif user_input == 'f':
            find_movie()
        elif user_input == 'q':
            print("Stopping Program...")
        else:
            print('This was an unknown command please try again')

        user_input = input("\nInterface Commands: a adds a movie, l to see your movies, f to find a movie, q to quit\n")


def add_movie():
    name = input('What is the name of the movie? ')
    director = input('Who is the director of the movie? ')
    year = int(input('What year did the movie come out? '))

    data_movies.append({
        'name': name,
        'director': director,
        'year': year
    })


def show_movies(data):
    for movie in data:
        show_movies_details(movie)


def show_movies_details(movie):
    print(f"\nName: {movie['name']}")
    print(f"Director: {movie['director']}")
    print(f"Year: {movie['year']}")


def find_movie():
    find_by = input("What property of the movie are you looking for?")  # name, director, or year
    looking_for = input("What are you searching for?")

    found_movies = find_by_attribute(data_movies, looking_for, lambda x: x[find_by])

    show_movies(found_movies)


def find_by_attribute(items, expected, finder):     # generic searching function
    found = []

    for i in items:
        if finder(i) == expected:
            found.append(i)

    return found


menu()
