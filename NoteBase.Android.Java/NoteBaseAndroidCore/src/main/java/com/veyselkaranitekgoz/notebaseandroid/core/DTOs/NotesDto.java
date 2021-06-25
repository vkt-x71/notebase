package com.veyselkaranitekgoz.notebaseandroid.core.DTOs;

import java.util.Date;

public class NotesDto {
    private int Id;
    private int NoteBookId;
    private String Title;
    private String Content;
    private Date CreationDate;
    private Date UpdateDate;
    private boolean IsDeleted;

    public int getId() {
        return Id;
    }

    public void setId(int id) {
        Id = id;
    }

    public int getNoteBookId() {
        return NoteBookId;
    }

    public void setNoteBookId(int noteBookId) {
        NoteBookId = noteBookId;
    }

    public String getTitle() {
        return Title;
    }

    public void setTitle(String title) {
        Title = title;
    }

    public String getContent() {
        return Content;
    }

    public void setContent(String content) {
        Content = content;
    }

    public Date getCreationDate() {
        return CreationDate;
    }

    public void setCreationDate(Date creationDate) {
        CreationDate = creationDate;
    }

    public Date getUpdateDate() {
        return UpdateDate;
    }

    public void setUpdateDate(Date updateDate) {
        UpdateDate = updateDate;
    }

    public boolean isDeleted() {
        return IsDeleted;
    }

    public void setDeleted(boolean deleted) {
        IsDeleted = deleted;
    }
}
