@echo off
for %%i in (*.proto) do ( 
	protoc --proto_path=./ --cpp_out=../ %%i
)