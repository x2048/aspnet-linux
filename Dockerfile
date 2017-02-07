FROM microsoft/dotnet:1.1-runtime
ADD . /app
WORKDIR /app
RUN dotnet run

