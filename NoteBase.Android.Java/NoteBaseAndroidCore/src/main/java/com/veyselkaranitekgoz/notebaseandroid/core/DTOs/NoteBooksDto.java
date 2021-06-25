package com.veyselkaranitekgoz.notebaseandroid.core.DTOs;

public class NoteBooksDto {
    private int Id;
    private String UserId;
    private int TopId;
    private String Name;
    private int OrderNumber;
    private bool IsDeleted;

    public int getId() {
        return Id;
    }

    public void setId(int id) {
        Id = id;
    }

    public String getUserId() {
        return UserId;
    }

    public void setUserId(String userId) {
        UserId = userId;
    }

    public int getTopId() {
        return TopId;
    }

    public void setTopId(int topId) {
        TopId = topId;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public int getOrderNumber() {
        return OrderNumber;
    }

    public void setOrderNumber(int orderNumber) {
        OrderNumber = orderNumber;
    }

    public bool getIsDeleted() {
        return IsDeleted;
    }

    public void setIsDeleted(bool isDeleted) {
        IsDeleted = isDeleted;
    }
}
