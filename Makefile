run-app:
	@echo "Running Recurse App"
	@go run ./cmd/app/main.go
run-client:
	@echo "Running Recurse Terminal Client..."
	@go run ./cmd/client/main.go
run-server:
	@echo "Running Recurse Server..."
	@go run ./cmd/server/main.go