FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Client/shared-todo.csproj", "src/Client/"]
RUN dotnet restore "src/Client/shared-todo.csproj"
COPY . .
WORKDIR "/src/src/Client"
RUN dotnet build shared-todo.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish shared-todo.csproj -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf