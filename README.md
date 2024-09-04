# SSC-Internship-Dev-ORM-Object-Mapping
# Giới Thiệu về ORM & Object Mapping
## 1. Giới Thiệu Về ORM
Object-Relational Mapping (ORM) là một kỹ thuật giúp lập trình viên làm việc với cơ sở dữ liệu thông qua các đối tượng trong code. Thay vì viết trực tiếp các câu lệnh SQL, bạn có thể tương tác với cơ sở dữ liệu thông qua các đối tượng và các lớp trong ngôn ngữ lập trình mà bạn sử dụng. Điều này làm cho quá trình phát triển dễ dàng hơn, tránh được lỗi và tăng hiệu quả làm việc.

## 2. Tại Sao Sử Dụng ORM?
- Giảm sự phụ thuộc vào SQL thuần túy: ORM giúp bạn viết ít SQL hơn, thay vào đó sử dụng ngôn ngữ lập trình quen thuộc để thao tác với dữ liệu.
- Bảo trì dễ dàng hơn: Việc bảo trì code trở nên dễ dàng hơn vì bạn đang làm việc với các đối tượng, không phải là các bảng cơ sở dữ liệu.
- Chuyển đổi giữa các hệ quản trị cơ sở dữ liệu: ORM giúp việc chuyển đổi giữa các loại cơ sở dữ liệu khác nhau trở nên đơn giản hơn, bởi vì bạn không cần phải thay đổi nhiều về cách xử lý dữ liệu.
## 3. Các Công Nghệ ORM Phổ Biến Trong .NET Core
Trong hệ sinh thái .NET, có hai công nghệ ORM nổi bật:
- Entity Framework Core: Một ORM mạnh mẽ được Microsoft phát triển, hỗ trợ nhiều loại cơ sở dữ liệu và tích hợp sâu vào .NET Core.
- Dapper: Một Micro ORM rất nhẹ và nhanh, phù hợp với các ứng dụng yêu cầu hiệu năng cao.
## 4. Giới Thiệu Về Object Mapping
Object Mapping là kỹ thuật giúp bạn chuyển đổi dữ liệu giữa các lớp đối tượng khác nhau. Điều này rất hữu ích khi bạn có các lớp DTO (Data Transfer Object) dùng để giao tiếp giữa các tầng khác nhau của ứng dụng và muốn chuyển đổi chúng từ/đến các lớp thực thể trong cơ sở dữ liệu.

## 5. Công Cụ Object Mapping Phổ Biến
- AutoMapper: Một thư viện giúp ánh xạ giữa các đối tượng một cách dễ dàng, giảm bớt boilerplate code khi chuyển đổi giữa các lớp.
## 6. Nội Dung Các Blog Hướng Dẫn

1. `Entity Framework Core`: Hướng dẫn chi tiết từ lý thuyết đến thực hành, bao gồm cách cài đặt, cấu hình, và làm việc với các database thông qua EF Core.
- Tìm hiểu về Entity Framework Core: [SSC-Internship-Dev-ORM](https://github.com/nguyentiu/SSC-Internship-Dev-ORM)
2. `Dapper`: Hướng dẫn về cách sử dụng Dapper, bao gồm cách thực hiện các thao tác CRUD nhanh chóng và hiệu quả.
- Tìm hiểu về Dapper: [SSC-Internship-Dev-Dappe](https://github.com/nguyentiu/SSC-Internship-Dev-Dapper)
3. `AutoMapper`: Giới thiệu về cách sử dụng AutoMapper để ánh xạ các đối tượng một cách tự động và linh hoạt.
- Tìm hiểu về AutoMapper: [SSC-Internship-Dev-AutoMapper](https://github.com/nguyentiu/SSC-Internship-Dev-AutoMapper)
