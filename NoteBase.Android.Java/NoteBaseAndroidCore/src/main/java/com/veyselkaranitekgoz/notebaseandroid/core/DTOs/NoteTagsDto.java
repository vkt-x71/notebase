package com.veyselkaranitekgoz.notebaseandroid.core.DTOs;

public class NoteTagsDto {
    private int Id;
    private int TagId;
    private int NoteId;

    public int getId() {
        return Id;
    }

    public void setId(int id) {
        Id = id;
    }

    public int getTagId() {
        return TagId;
    }

    public void setTagId(int tagId) {
        TagId = tagId;
    }

    public int getNoteId() {
        return NoteId;
    }

    public void setNoteId(int noteId) {
        NoteId = noteId;
    }
}
