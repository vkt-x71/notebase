package com.veyselkaranitekgoz.notebaseandroid.core.DTOs;

public class UserAppDto {
    private String Id { get; set; }
    private String UserName { get; set; }
    private String Email { get; set; }

    public String getId() {
        return Id;
    }

    public void setId(String id) {
        Id = id;
    }

    public String getUserName() {
        return UserName;
    }

    public void setUserName(String userName) {
        UserName = userName;
    }

    public String getEmail() {
        return Email;
    }

    public void setEmail(String email) {
        Email = email;
    }
}
