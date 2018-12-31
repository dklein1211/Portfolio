class Car:
    def __init__(self, make, model):
        self.make = make
        self.model = model

    def __repr__(self):
        return f'<Car {self.make} {self.model}'


class Garage:
    def __init__(self):
        self.cars = []

    def __len__(self):
            return len(self.cars)

    def add_car(self, car):
        if not isinstance(car, Car):  # checks if the parameter car is an instance of type Car
            raise TypeError(f'Tried to add a "{car.__class__.__name__}" to the garage, '
                            f'but you can only add "Car" objects.')
            # This error makes it so only type Car is allowed and is the best way to do error handling.
        self.cars.append(car)


ford = Garage()
focus = Car('Ford', 'Focus')
ford.add_car(focus)

try:
    ford.add_car('Ford')
except TypeError:
    print('Error: This is not of type Car')
except ValueError:
    print('Error: Something really bad happened...')
finally:
    print(f'The garage now has {len(ford)} cars')

escape = Car('Ford', 'Escape')
ford.add_car(escape)
print(len(ford))
