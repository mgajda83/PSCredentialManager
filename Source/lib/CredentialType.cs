﻿namespace CredentialManagement
{
    // Based on project credentialmanagement by ilyalozovyy
    // https://github.com/ilyalozovyy/credentialmanagement/

    public enum CredentialType: uint 
    {
        None = 0,
        Generic = 1,
        DomainPassword = 2,
        DomainCertificate = 3,
        DomainVisiblePassword = 4
    }
}
