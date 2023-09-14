# FROM mcr.microsoft.com/dotnet/sdk:7.0
# WORKDIR /work
# COPY *.csproj .
# RUN dotnet restore
# COPY . .
# #3-4がいらんかも
# RUN dotnet publish -c Release -o out
# WORKDIR /work/out
# ENTRYPOINT ["dotnet", "console.dll","Program.cs","aaa"]

FROM mcr.microsoft.com/dotnet/sdk:7.0 as builder
WORKDIR /work
# COPY *.csproj .
# RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o out
FROM mcr.microsoft.com/dotnet/runtime:7.0
WORKDIR /work
COPY --from=builder /work/out/* .
ENTRYPOINT ["dotnet", "console.dll","Program.cs","aaa"]