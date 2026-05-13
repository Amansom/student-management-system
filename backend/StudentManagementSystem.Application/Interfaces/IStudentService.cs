using StudentManagementSystem.Application.DTOs;

namespace StudentManagementSystem.Application.Interfaces;

public interface IStudentService
{
    Task<List<StudentDto>> GetAllStudentsAsync();

    Task<StudentDto> AddStudentAsync(CreateStudentDto dto);

    Task<StudentDto> UpdateStudentAsync(int id, UpdateStudentDto dto);

    Task<bool> DeleteStudentAsync(int id);
}