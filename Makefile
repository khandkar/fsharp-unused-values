.PHONY: all build clean rebuild run find_boms

all: rebuild
	$(MAKE) run

rebuild: clean
	$(MAKE) build

build:
	dotnet build

run:
	dotnet run

clean:
	rm -rf bin obj
