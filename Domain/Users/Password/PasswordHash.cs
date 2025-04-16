using System.Security.Cryptography;
using System.Text;

namespace Battleship.Domain.Users.Password;

public sealed class PasswordHash
{
    private readonly byte[] _passwordHash;
    
    #region Hashing

    public PasswordHash(string password)
    {
        _passwordHash = HashPassword(password);
    }

    private byte[] HashPassword(string password)
    {
        if (string.IsNullOrEmpty(password))
            throw new ArgumentException("Password cannot be empty");
        
        using var sha256 = SHA512.Create();
        return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
    }
    
    #endregion
    
    #region Verifying
    
    public PasswordHash(byte[] passwordHash) => _passwordHash = passwordHash;

    public bool Verify(string passwordAttempt)
    {
        if (string.IsNullOrEmpty(passwordAttempt))
            return false;
        
        var hashAttempt = HashPassword(passwordAttempt);
        if (hashAttempt.Length != _passwordHash.Length)
            return false;

        for (var i = 0; i < _passwordHash.Length; i++)
        {
            if (hashAttempt[i] != _passwordHash[i])
                return false;
        }

        return true;
    }
    
    #endregion

    public byte[] ToArray() => _passwordHash;
}