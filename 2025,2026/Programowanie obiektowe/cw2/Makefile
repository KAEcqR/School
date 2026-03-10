CXX = g++
CXXFLAGS = -Wall -std=c++17
SRC = $(wildcard *.cpp)
OUT = cw2

all: $(OUT)

$(OUT): $(SRC)
	$(CXX) $(CXXFLAGS) $(SRC) -o $(OUT)

run: all
	./$(OUT)

clean:
	rm -f $(OUT)
