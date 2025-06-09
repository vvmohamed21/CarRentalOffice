using System.ComponentModel.DataAnnotations;

public class RegisterViewModel
{
    [Required(ErrorMessage = "البريد الإلكتروني مطلوب")]
    [EmailAddress(ErrorMessage = "صيغة البريد الإلكتروني غير صحيحة")]
    public string Email { get; set; }

    [Required(ErrorMessage = "كلمة المرور مطلوبة")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "كلمة المرور يجب أن تكون على الأقل 6 أحرف")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required(ErrorMessage = "تأكيد كلمة المرور مطلوب")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "كلمة المرور وتأكيدها غير متطابقتين")]
    public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "الاسم مطلوب")]
    public string FullName { get; set; }
}
