# Recipes
# ������� �� ��������� �������

## ��������
"������� �� ��������� �������" � ASP.NET Core MVC ����������, ����� ��������� �� ������������� �� ��������, ����������, ���������� � �������� ��������� �������. ������������ �������� ���������� �� ���������, �������� � �������� ���������� �� ����� �������.

## ���������������
- **CRUD ��������** �� �������, ��������� � ��������
- **��������� �� ������� � ���������**
- **���������� �� �������� �� ����� �������**
- **������� � ��������� �� ����������� ��� ���������**

## ����������
- **ASP.NET Core MVC** � �� ��� ������������
- **Entity Framework Core** � �� ���������� �� ������ �����
- **Microsoft SQL Server** � �� ���������� �� �����

## ��������� �� ������ �����
������������ �������� �������� ������� ������:

### Recipe (�������)
- `RecipeId` � �������� �������������
- `Title` � �������� �� ���������
- `Description` � ������ ��������
- `CookingTime` � ����� �� �������
- `Instructions` � ���������� �� ����������
- `CategoryId` � ������ ��� �����������
- `ImagePath` � ��� �� �����������
- `RecipeIngredients` � �������� �� ��������

### Category (���������)
- `CategoryId` � �������� �������������
- `Name` � ��� �� �����������
- `Recipes` � ������ � ������� � �����������

### Ingredient (��������)
- `IngredientId` � �������� �������������
- `Name` � ��� �� ����������
- `RecipeIngredients` � �������, ����� �������� ���� ��������

### RecipeIngredient (�������� � �������)
- `RecipeIngredientId` � �������� �������������
- `RecipeId` � ������ ��� �������
- `IngredientId` � ������ ��� ��������
- `Quantity` � ����������

## ���������� � ����������
1. **��������� �� �����������:**
   ```bash
   git clone https://github.com/your-repository-url.git
   cd your-repository-folder
   ```
2. **������������� �� ������ �����:**
   - ������� `appsettings.json`, �� �� ������� ������ ��� ������ �����.
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=.;Database=RecipesDb;Trusted_Connection=True;"
   }
   ```
3. **���������� �� ��������:**
   ```bash
   dotnet ef database update
   ```
4. **���������� �� ������������:**
   ```bash
   dotnet run
   ```
5. **�������� � �������:**
   ```
   http://localhost:5000
   ```

## ������
- [������ ���]
- [������������ ������, ��� ���]

## ������
���� ������ � ���������� ��� MIT License.

