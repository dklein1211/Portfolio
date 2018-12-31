my_file = open('data.txt', 'r')  # Filename and read mode
read_file = my_file.read()

my_file.close()

print(read_file)

name = input('What is your name?\n')

write_file = open('data.txt', 'w')
write_file.write(name)

write_file.close()
