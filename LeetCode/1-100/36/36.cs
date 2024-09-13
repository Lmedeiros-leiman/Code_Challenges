using System;
using System.Collections.Generic;
using Internal;

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        


        for (int i = 0; i < board.Length; i++) {
            bool[] linha = { false,false,false,false,false,false,false,false,false,false };
            bool[] coluna = { false,false,false,false,false,false,false,false,false,false };
            bool[] bloco = { false,false,false,false,false,false,false,false,false,false };

            for (int l = 0; l < board[i].Length; l++) {
                if ( board[i][l] == '.' ) { continue; }
                
                int linhaAtual = (int) board[i][l] - 48;
                
                if (linha[linhaAtual]) {
                    return false;
                } else {
                    linha[linhaAtual] = true;
                }
                    
            }
            
            for (int r = 0; r < board.Length; r++) {
                
                if ( board[r][i] == '.' ) { continue; }
                
                int colunaAtual = (int) board[r][i] - 48;
                
                if (coluna[colunaAtual]) {
                    return false;
                } else {
                    coluna[colunaAtual] = true;
                }
                    
            }
            
            
            
            for (int b = 0; b < board.Length; b++) {
                if ( board[i/3*3+b/3][i%3*3+b%3] == '.' ) { continue; }


                int blocoAtual = (int) board[i/3*3+b/3][i%3*3+b%3] - 48;
                
                if (bloco[blocoAtual]) {
                    return false;
                } else {
                    bloco[blocoAtual] = true;
                }
            }
            

        }

        return true;
        
    }
}